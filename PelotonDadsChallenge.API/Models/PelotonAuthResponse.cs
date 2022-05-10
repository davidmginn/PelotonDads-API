using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PelotonDadsChallenge.API.Models
{
    public class PelotonAuthResponse
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_data")]
        public UserData UserData { get; set; }

        [JsonProperty("pubsub_session")]
        public PubsubSession PubsubSession { get; set; }
    }

    public class QuickHits
    {
        [JsonProperty("quick_hits_enabled")]
        public bool QuickHitsEnabled { get; set; }

        [JsonProperty("speed_shortcuts")]
        public object SpeedShortcuts { get; set; }

        [JsonProperty("incline_shortcuts")]
        public object InclineShortcuts { get; set; }
    }

    public class ContractAgreement
    {
        [JsonProperty("contract_type")]
        public string ContractType { get; set; }

        [JsonProperty("contract_id")]
        public string ContractId { get; set; }

        [JsonProperty("contract_created_at")]
        public int ContractCreatedAt { get; set; }

        [JsonProperty("bike_contract_url")]
        public string BikeContractUrl { get; set; }

        [JsonProperty("tread_contract_url")]
        public string TreadContractUrl { get; set; }

        [JsonProperty("agreed_at")]
        public int AgreedAt { get; set; }

        [JsonProperty("contract_display_name")]
        public string ContractDisplayName { get; set; }
    }

    public class PairedDevice
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("paired_device_type")]
        public string PairedDeviceType { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }
    }

    public class WorkoutCount
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }
    }

    public class UserData
    {
        [JsonProperty("facebook_access_token")]
        public object FacebookAccessToken { get; set; }

        [JsonProperty("customized_heart_rate_zones")]
        public List<object> CustomizedHeartRateZones { get; set; }

        [JsonProperty("estimated_cycling_ftp")]
        public int EstimatedCyclingFtp { get; set; }

        [JsonProperty("cycling_workout_ftp")]
        public int CyclingWorkoutFtp { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("total_pending_followers")]
        public int TotalPendingFollowers { get; set; }

        [JsonProperty("quick_hits")]
        public QuickHits QuickHits { get; set; }

        [JsonProperty("instructor_id")]
        public object InstructorId { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("cycling_ftp_source")]
        public object CyclingFtpSource { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("is_fitbit_authenticated")]
        public bool IsFitbitAuthenticated { get; set; }

        [JsonProperty("block_explicit")]
        public bool BlockExplicit { get; set; }

        [JsonProperty("gender")]
        public object Gender { get; set; }

        [JsonProperty("member_groups")]
        public List<object> MemberGroups { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("total_pedaling_metric_workouts")]
        public int TotalPedalingMetricWorkouts { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("default_heart_rate_zones")]
        public List<object> DefaultHeartRateZones { get; set; }

        [JsonProperty("total_workouts")]
        public int TotalWorkouts { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("has_active_digital_subscription")]
        public bool HasActiveDigitalSubscription { get; set; }

        [JsonProperty("contract_agreements")]
        public List<ContractAgreement> ContractAgreements { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("has_active_device_subscription")]
        public bool HasActiveDeviceSubscription { get; set; }

        [JsonProperty("obfuscated_email")]
        public string ObfuscatedEmail { get; set; }

        [JsonProperty("referrals_made")]
        public int ReferralsMade { get; set; }

        [JsonProperty("is_internal_beta_tester")]
        public bool IsInternalBetaTester { get; set; }

        [JsonProperty("paired_devices")]
        public List<PairedDevice> PairedDevices { get; set; }

        [JsonProperty("created_country")]
        public string CreatedCountry { get; set; }

        [JsonProperty("phone_number")]
        public object PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("cycling_ftp_workout_id")]
        public object CyclingFtpWorkoutId { get; set; }

        [JsonProperty("facebook_id")]
        public object FacebookId { get; set; }

        [JsonProperty("is_demo")]
        public bool IsDemo { get; set; }

        [JsonProperty("workout_counts")]
        public List<WorkoutCount> WorkoutCounts { get; set; }

        [JsonProperty("v1_referrals_made")]
        public int V1ReferralsMade { get; set; }

        [JsonProperty("allow_marketing")]
        public bool AllowMarketing { get; set; }

        [JsonProperty("customized_max_heart_rate")]
        public int CustomizedMaxHeartRate { get; set; }

        [JsonProperty("is_strava_authenticated")]
        public bool IsStravaAuthenticated { get; set; }

        [JsonProperty("is_provisional")]
        public bool IsProvisional { get; set; }

        [JsonProperty("is_complete_profile")]
        public bool IsCompleteProfile { get; set; }

        [JsonProperty("cycling_ftp")]
        public int CyclingFtp { get; set; }

        [JsonProperty("has_signed_waiver")]
        public bool HasSignedWaiver { get; set; }

        [JsonProperty("is_effort_score_enabled")]
        public bool IsEffortScoreEnabled { get; set; }

        [JsonProperty("default_max_heart_rate")]
        public int DefaultMaxHeartRate { get; set; }

        [JsonProperty("is_external_beta_tester")]
        public bool IsExternalBetaTester { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_workout_at")]
        public object LastWorkoutAt { get; set; }

        [JsonProperty("total_non_pedaling_metric_workouts")]
        public int TotalNonPedalingMetricWorkouts { get; set; }

        [JsonProperty("total_followers")]
        public int TotalFollowers { get; set; }

        [JsonProperty("birthday")]
        public object Birthday { get; set; }

        [JsonProperty("can_charge")]
        public bool CanCharge { get; set; }

        [JsonProperty("total_following")]
        public int TotalFollowing { get; set; }

        [JsonProperty("is_profile_private")]
        public bool IsProfilePrivate { get; set; }

        [JsonProperty("middle_initial")]
        public string MiddleInitial { get; set; }
    }

    public class PubsubSession
    {
    }
}
