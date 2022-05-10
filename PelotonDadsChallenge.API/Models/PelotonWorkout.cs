using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PelotonDadsChallenge.API.Models
{
    //public class Availability
    //{
    //    [JsonProperty("is_available")]
    //    public bool IsAvailable { get; set; }

    //    [JsonProperty("reason")]
    //    public object Reason { get; set; }
    //}

    //public class WorkoutShareImage
    //{
    //    [JsonProperty("fitness_discipline")]
    //    public string FitnessDiscipline { get; set; }

    //    [JsonProperty("image_url")]
    //    public string ImageUrl { get; set; }
    //}

    //public class Instructor
    //{
    //    [JsonProperty("id")]
    //    public string Id { get; set; }

    //    [JsonProperty("bio")]
    //    public string Bio { get; set; }

    //    [JsonProperty("short_bio")]
    //    public string ShortBio { get; set; }

    //    [JsonProperty("coach_type")]
    //    public string CoachType { get; set; }

    //    [JsonProperty("is_filterable")]
    //    public bool IsFilterable { get; set; }

    //    [JsonProperty("is_instructor_group")]
    //    public bool IsInstructorGroup { get; set; }

    //    [JsonProperty("is_visible")]
    //    public bool IsVisible { get; set; }

    //    [JsonProperty("list_order")]
    //    public int ListOrder { get; set; }

    //    [JsonProperty("featured_profile")]
    //    public bool FeaturedProfile { get; set; }

    //    [JsonProperty("film_link")]
    //    public string FilmLink { get; set; }

    //    [JsonProperty("facebook_fan_page")]
    //    public string FacebookFanPage { get; set; }

    //    [JsonProperty("music_bio")]
    //    public string MusicBio { get; set; }

    //    [JsonProperty("spotify_playlist_uri")]
    //    public string SpotifyPlaylistUri { get; set; }

    //    [JsonProperty("background")]
    //    public string Background { get; set; }

    //    [JsonProperty("ordered_q_and_as")]
    //    public List<List<string>> OrderedQAndAs { get; set; }

    //    [JsonProperty("instagram_profile")]
    //    public string InstagramProfile { get; set; }

    //    [JsonProperty("strava_profile")]
    //    public string StravaProfile { get; set; }

    //    [JsonProperty("twitter_profile")]
    //    public string TwitterProfile { get; set; }

    //    [JsonProperty("quote")]
    //    public string Quote { get; set; }

    //    [JsonProperty("username")]
    //    public string Username { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("first_name")]
    //    public string FirstName { get; set; }

    //    [JsonProperty("last_name")]
    //    public string LastName { get; set; }

    //    [JsonProperty("user_id")]
    //    public string UserId { get; set; }

    //    [JsonProperty("life_style_image_url")]
    //    public string LifeStyleImageUrl { get; set; }

    //    [JsonProperty("bike_instructor_list_display_image_url")]
    //    public object BikeInstructorListDisplayImageUrl { get; set; }

    //    [JsonProperty("web_instructor_list_display_image_url")]
    //    public string WebInstructorListDisplayImageUrl { get; set; }

    //    [JsonProperty("ios_instructor_list_display_image_url")]
    //    public string IosInstructorListDisplayImageUrl { get; set; }

    //    [JsonProperty("about_image_url")]
    //    public string AboutImageUrl { get; set; }

    //    [JsonProperty("image_url")]
    //    public string ImageUrl { get; set; }

    //    [JsonProperty("jumbotron_url")]
    //    public object JumbotronUrl { get; set; }

    //    [JsonProperty("jumbotron_url_dark")]
    //    public string JumbotronUrlDark { get; set; }

    //    [JsonProperty("jumbotron_url_ios")]
    //    public string JumbotronUrlIos { get; set; }

    //    [JsonProperty("web_instructor_list_gif_image_url")]
    //    public object WebInstructorListGifImageUrl { get; set; }

    //    [JsonProperty("instructor_hero_image_url")]
    //    public string InstructorHeroImageUrl { get; set; }

    //    [JsonProperty("workout_share_images")]
    //    public List<WorkoutShareImage> WorkoutShareImages { get; set; }

    //    [JsonProperty("fitness_disciplines")]
    //    public List<string> FitnessDisciplines { get; set; }
    //}

    //public class Ride
    //{
    //    [JsonProperty("has_closed_captions")]
    //    public bool HasClosedCaptions { get; set; }

    //    [JsonProperty("content_provider")]
    //    public string ContentProvider { get; set; }

    //    [JsonProperty("content_format")]
    //    public string ContentFormat { get; set; }

    //    [JsonProperty("description")]
    //    public string Description { get; set; }

    //    [JsonProperty("difficulty_rating_avg")]
    //    public double DifficultyRatingAvg { get; set; }

    //    [JsonProperty("difficulty_rating_count")]
    //    public int DifficultyRatingCount { get; set; }

    //    [JsonProperty("difficulty_level")]
    //    public string DifficultyLevel { get; set; }

    //    [JsonProperty("duration")]
    //    public int Duration { get; set; }

    //    [JsonProperty("extra_images")]
    //    public List<object> ExtraImages { get; set; }

    //    [JsonProperty("fitness_discipline")]
    //    public string FitnessDiscipline { get; set; }

    //    [JsonProperty("fitness_discipline_display_name")]
    //    public string FitnessDisciplineDisplayName { get; set; }

    //    [JsonProperty("has_pedaling_metrics")]
    //    public bool HasPedalingMetrics { get; set; }

    //    [JsonProperty("home_peloton_id")]
    //    public string HomePelotonId { get; set; }

    //    [JsonProperty("id")]
    //    public string Id { get; set; }

    //    [JsonProperty("image_url")]
    //    public string ImageUrl { get; set; }

    //    [JsonProperty("instructor_id")]
    //    public string InstructorId { get; set; }

    //    [JsonProperty("is_archived")]
    //    public bool IsArchived { get; set; }

    //    [JsonProperty("is_closed_caption_shown")]
    //    public bool IsClosedCaptionShown { get; set; }

    //    [JsonProperty("is_explicit")]
    //    public bool IsExplicit { get; set; }

    //    [JsonProperty("is_live_in_studio_only")]
    //    public bool IsLiveInStudioOnly { get; set; }

    //    [JsonProperty("language")]
    //    public string Language { get; set; }

    //    [JsonProperty("length")]
    //    public int Length { get; set; }

    //    [JsonProperty("live_stream_id")]
    //    public string LiveStreamId { get; set; }

    //    [JsonProperty("live_stream_url")]
    //    public object LiveStreamUrl { get; set; }

    //    [JsonProperty("location")]
    //    public string Location { get; set; }

    //    [JsonProperty("metrics")]
    //    public List<string> Metrics { get; set; }

    //    [JsonProperty("origin_locale")]
    //    public string OriginLocale { get; set; }

    //    [JsonProperty("original_air_time")]
    //    public int OriginalAirTime { get; set; }

    //    [JsonProperty("overall_rating_avg")]
    //    public double OverallRatingAvg { get; set; }

    //    [JsonProperty("overall_rating_count")]
    //    public int OverallRatingCount { get; set; }

    //    [JsonProperty("pedaling_start_offset")]
    //    public int PedalingStartOffset { get; set; }

    //    [JsonProperty("pedaling_end_offset")]
    //    public int PedalingEndOffset { get; set; }

    //    [JsonProperty("pedaling_duration")]
    //    public int PedalingDuration { get; set; }

    //    [JsonProperty("rating")]
    //    public int Rating { get; set; }

    //    [JsonProperty("ride_type_id")]
    //    public string RideTypeId { get; set; }

    //    [JsonProperty("ride_type_ids")]
    //    public List<string> RideTypeIds { get; set; }

    //    [JsonProperty("sample_vod_stream_url")]
    //    public object SampleVodStreamUrl { get; set; }

    //    [JsonProperty("scheduled_start_time")]
    //    public int ScheduledStartTime { get; set; }

    //    [JsonProperty("series_id")]
    //    public string SeriesId { get; set; }

    //    [JsonProperty("sold_out")]
    //    public bool SoldOut { get; set; }

    //    [JsonProperty("studio_peloton_id")]
    //    public string StudioPelotonId { get; set; }

    //    [JsonProperty("title")]
    //    public string Title { get; set; }

    //    [JsonProperty("total_ratings")]
    //    public int TotalRatings { get; set; }

    //    [JsonProperty("total_in_progress_workouts")]
    //    public int TotalInProgressWorkouts { get; set; }

    //    [JsonProperty("total_workouts")]
    //    public int TotalWorkouts { get; set; }

    //    [JsonProperty("vod_stream_url")]
    //    public string VodStreamUrl { get; set; }

    //    [JsonProperty("vod_stream_id")]
    //    public string VodStreamId { get; set; }

    //    [JsonProperty("class_type_ids")]
    //    public List<string> ClassTypeIds { get; set; }

    //    [JsonProperty("difficulty_estimate")]
    //    public double DifficultyEstimate { get; set; }

    //    [JsonProperty("overall_estimate")]
    //    public double OverallEstimate { get; set; }

    //    [JsonProperty("availability")]
    //    public Availability Availability { get; set; }

    //    [JsonProperty("instructor")]
    //    public Instructor Instructor { get; set; }
    //}

    public class PelotonWorkoutResponse
    {
        [JsonProperty("data")]
        public List<PelotonWorkout> Data { get; set; }
    }

    public class PelotonWorkout
    {
        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        [JsonProperty("end_time")]
        public int EndTime { get; set; }

        [JsonProperty("fitbit_id")]
        public object FitbitId { get; set; }

        [JsonProperty("fitness_discipline")]
        public string FitnessDiscipline { get; set; }

        [JsonProperty("has_pedaling_metrics")]
        public bool HasPedalingMetrics { get; set; }

        [JsonProperty("has_leaderboard_metrics")]
        public bool HasLeaderboardMetrics { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_total_work_personal_record")]
        public bool IsTotalWorkPersonalRecord { get; set; }

        [JsonProperty("metrics_type")]
        public string MetricsType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("peloton_id")]
        public string PelotonId { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("start_time")]
        public int StartTime { get; set; }

        [JsonProperty("strava_id")]
        public object StravaId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("total_work")]
        public double TotalWork { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("workout_type")]
        public string WorkoutType { get; set; }

        //[JsonProperty("total_video_watch_time_seconds")]
        //public int TotalVideoWatchTimeSeconds { get; set; }

        //[JsonProperty("total_video_buffering_seconds")]
        //public int TotalVideoBufferingSeconds { get; set; }

        //[JsonProperty("v2_total_video_watch_time_seconds")]
        //public int V2TotalVideoWatchTimeSeconds { get; set; }

        //[JsonProperty("v2_total_video_buffering_seconds")]
        //public int V2TotalVideoBufferingSeconds { get; set; }

        //[JsonProperty("total_music_audio_play_seconds")]
        //public object TotalMusicAudioPlaySeconds { get; set; }

        //[JsonProperty("total_music_audio_buffer_seconds")]
        //public object TotalMusicAudioBufferSeconds { get; set; }

        //[JsonProperty("ride")]
        //public Ride Ride { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("device_time_created_at")]
        public int DeviceTimeCreatedAt { get; set; }

        [JsonProperty("effort_zones")]
        public object EffortZones { get; set; }
    }
}
