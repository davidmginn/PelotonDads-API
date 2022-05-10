using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using PelotonDadsChallenge.API.Configuration;
using PelotonDadsChallenge.API.Services;

namespace PelotonDadsChallenge.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddMicrosoftIdentityWebApi(options =>
                    {
                        Configuration.Bind("AzureAdB2C", options);

                        options.TokenValidationParameters.NameClaimType = "name";


                    },
                    options => { Configuration.Bind("AzureAdB2C", options); });

            //Dependency configuration
            services.Configure<PelotonConfiguration>(Configuration.GetSection("Peloton"));
            services.Configure<ConnectionStringsConfiguration>(Configuration.GetSection("ConnectionStrings"));
            services.AddScoped<IPelotonAuthenticationService, PelotonAuthenticationService>();
            services.AddScoped<IPelotonUserService, PelotonUserService>();
            services.AddScoped<IAppUserChallengeResultsService, AppUserChallengeResultsService>();
            services.AddScoped<IPelotonWorkoutsService, PelotonWorkoutsService>();

            var origins = Configuration.GetSection("AllowedOrigins").Get<string[]>();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins(origins)
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });

            services.AddControllers();

            //services.AddAuthorization(options =>
            //{
            //    // Create policy to check for the scope 'read'
            //    options.AddPolicy("ReadScope",
            //        policy => policy.Requirements.Add(new ScopesRequirement("read")));
            //});

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PelotonDadsChallenge.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PelotonDadsChallenge.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
