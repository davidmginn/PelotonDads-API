using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PelotonDadsChallenge.API.Models
{
    public class PelotonUser
    {
        [JsonProperty("workout_counts")]
        public List<WorkoutCount> WorkoutCounts { get; set; }

        [JsonProperty("cycling_ftp_source")]
        public object CyclingFtpSource { get; set; }

        [JsonProperty("gender")]
        public object Gender { get; set; }

        [JsonProperty("has_active_digital_subscription")]
        public bool HasActiveDigitalSubscription { get; set; }

        [JsonProperty("external_music_auth_list")]
        public List<ExternalMusicAuthList> ExternalMusicAuthList { get; set; }

        [JsonProperty("total_followers")]
        public int TotalFollowers { get; set; }

        [JsonProperty("estimated_cycling_ftp")]
        public int EstimatedCyclingFtp { get; set; }

        [JsonProperty("default_max_heart_rate")]
        public int DefaultMaxHeartRate { get; set; }

        [JsonProperty("tags_info")]
        public TagsInfo TagsInfo { get; set; }

        [JsonProperty("birthday")]
        public object Birthday { get; set; }

        [JsonProperty("cycling_workout_ftp")]
        public int CyclingWorkoutFtp { get; set; }

        [JsonProperty("facebook_access_token")]
        public object FacebookAccessToken { get; set; }

        [JsonProperty("is_effort_score_enabled")]
        public bool IsEffortScoreEnabled { get; set; }

        [JsonProperty("can_charge")]
        public bool CanCharge { get; set; }

        [JsonProperty("has_signed_waiver")]
        public bool HasSignedWaiver { get; set; }

        [JsonProperty("phone_number")]
        public object PhoneNumber { get; set; }

        [JsonProperty("relationship")]
        public Relationship Relationship { get; set; }

        [JsonProperty("allow_marketing")]
        public bool AllowMarketing { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customized_heart_rate_zones")]
        public List<object> CustomizedHeartRateZones { get; set; }

        [JsonProperty("default_heart_rate_zones")]
        public List<object> DefaultHeartRateZones { get; set; }

        [JsonProperty("customized_max_heart_rate")]
        public int CustomizedMaxHeartRate { get; set; }

        [JsonProperty("obfuscated_email")]
        public string ObfuscatedEmail { get; set; }

        [JsonProperty("quick_hits")]
        public QuickHits QuickHits { get; set; }

        [JsonProperty("total_following")]
        public int TotalFollowing { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("instructor_id")]
        public object InstructorId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("is_fitbit_authenticated")]
        public bool IsFitbitAuthenticated { get; set; }

        [JsonProperty("total_workouts")]
        public int TotalWorkouts { get; set; }

        [JsonProperty("total_pedaling_metric_workouts")]
        public int TotalPedalingMetricWorkouts { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("referrals_made")]
        public int ReferralsMade { get; set; }

        [JsonProperty("total_pending_followers")]
        public int TotalPendingFollowers { get; set; }

        [JsonProperty("is_internal_beta_tester")]
        public bool IsInternalBetaTester { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("cycling_ftp")]
        public int CyclingFtp { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("is_demo")]
        public bool IsDemo { get; set; }

        [JsonProperty("streaks")]
        public Streaks Streaks { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("is_strava_authenticated")]
        public bool IsStravaAuthenticated { get; set; }

        [JsonProperty("v1_referrals_made")]
        public int V1ReferralsMade { get; set; }

        [JsonProperty("block_explicit")]
        public bool BlockExplicit { get; set; }

        [JsonProperty("is_profile_private")]
        public bool IsProfilePrivate { get; set; }

        [JsonProperty("facebook_id")]
        public object FacebookId { get; set; }

        [JsonProperty("member_groups")]
        public List<object> MemberGroups { get; set; }

        [JsonProperty("contract_agreements")]
        public List<ContractAgreement> ContractAgreements { get; set; }

        [JsonProperty("cycling_ftp_workout_id")]
        public object CyclingFtpWorkoutId { get; set; }

        [JsonProperty("is_onboarded")]
        public IsOnboarded IsOnboarded { get; set; }

        [JsonProperty("last_workout_at")]
        public object LastWorkoutAt { get; set; }

        [JsonProperty("paired_devices")]
        public List<PairedDevice> PairedDevices { get; set; }

        [JsonProperty("has_active_device_subscription")]
        public bool HasActiveDeviceSubscription { get; set; }

        [JsonProperty("is_complete_profile")]
        public bool IsCompleteProfile { get; set; }

        [JsonProperty("is_provisional")]
        public bool IsProvisional { get; set; }

        [JsonProperty("is_external_beta_tester")]
        public bool IsExternalBetaTester { get; set; }

        [JsonProperty("total_non_pedaling_metric_workouts")]
        public int TotalNonPedalingMetricWorkouts { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("created_country")]
        public string CreatedCountry { get; set; }

        [JsonProperty("middle_initial")]
        public string MiddleInitial { get; set; }
    }

    public class ExternalMusicAuthList
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }
    }

    public class TagsInfo
    {
        [JsonProperty("primary_name")]
        public string PrimaryName { get; set; }

        [JsonProperty("primary_tag_background_image_url")]
        public string PrimaryTagBackgroundImageUrl { get; set; }

        [JsonProperty("total_joined")]
        public int TotalJoined { get; set; }
    }

    public class Relationship
    {
        [JsonProperty("me_to_user")]
        public string MeToUser { get; set; }

        [JsonProperty("user_to_me")]
        public string UserToMe { get; set; }
    }


    public class Streaks
    {
        [JsonProperty("current_weekly")]
        public int CurrentWeekly { get; set; }

        [JsonProperty("best_weekly")]
        public int BestWeekly { get; set; }

        [JsonProperty("start_date_of_current_weekly")]
        public int StartDateOfCurrentWeekly { get; set; }
    }


    public class IsOnboarded
    {
    }
}
