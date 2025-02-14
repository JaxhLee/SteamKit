// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: enums.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public enum EPublishedFileQueryType
    {
        k_PublishedFileQueryType_RankedByVote = 0,
        k_PublishedFileQueryType_RankedByPublicationDate = 1,
        k_PublishedFileQueryType_AcceptedForGameRankedByAcceptanceDate = 2,
        k_PublishedFileQueryType_RankedByTrend = 3,
        k_PublishedFileQueryType_FavoritedByFriendsRankedByPublicationDate = 4,
        k_PublishedFileQueryType_CreatedByFriendsRankedByPublicationDate = 5,
        k_PublishedFileQueryType_RankedByNumTimesReported = 6,
        k_PublishedFileQueryType_CreatedByFollowedUsersRankedByPublicationDate = 7,
        k_PublishedFileQueryType_NotYetRated = 8,
        k_PublishedFileQueryType_RankedByTotalUniqueSubscriptions = 9,
        k_PublishedFileQueryType_RankedByTotalVotesAsc = 10,
        k_PublishedFileQueryType_RankedByVotesUp = 11,
        k_PublishedFileQueryType_RankedByTextSearch = 12,
        k_PublishedFileQueryType_RankedByPlaytimeTrend = 13,
        k_PublishedFileQueryType_RankedByTotalPlaytime = 14,
        k_PublishedFileQueryType_RankedByAveragePlaytimeTrend = 15,
        k_PublishedFileQueryType_RankedByLifetimeAveragePlaytime = 16,
        k_PublishedFileQueryType_RankedByPlaytimeSessionsTrend = 17,
        k_PublishedFileQueryType_RankedByLifetimePlaytimeSessions = 18,
        k_PublishedFileQueryType_RankedByInappropriateContentRating = 19,
        k_PublishedFileQueryType_RankedByBanContentCheck = 20,
        k_PublishedFileQueryType_RankedByLastUpdatedDate = 21,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EPublishedFileInappropriateProvider
    {
        k_EPublishedFileInappropriateProvider_Invalid = 0,
        k_EPublishedFileInappropriateProvider_Google = 1,
        k_EPublishedFileInappropriateProvider_Amazon = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EPublishedFileInappropriateResult
    {
        k_EPublishedFileInappropriateResult_NotScanned = 0,
        k_EPublishedFileInappropriateResult_VeryUnlikely = 1,
        k_EPublishedFileInappropriateResult_Unlikely = 30,
        k_EPublishedFileInappropriateResult_Possible = 50,
        k_EPublishedFileInappropriateResult_Likely = 75,
        k_EPublishedFileInappropriateResult_VeryLikely = 100,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EPersonaStateFlag
    {
        k_EPersonaStateFlag_HasRichPresence = 1,
        k_EPersonaStateFlag_InJoinableGame = 2,
        k_EPersonaStateFlag_Golden = 4,
        k_EPersonaStateFlag_RemotePlayTogether = 8,
        k_EPersonaStateFlag_ClientTypeWeb = 256,
        k_EPersonaStateFlag_ClientTypeMobile = 512,
        k_EPersonaStateFlag_ClientTypeTenfoot = 1024,
        k_EPersonaStateFlag_ClientTypeVR = 2048,
        k_EPersonaStateFlag_LaunchTypeGamepad = 4096,
        k_EPersonaStateFlag_LaunchTypeCompatTool = 8192,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EContentCheckProvider
    {
        k_EContentCheckProvider_Invalid = 0,
        k_EContentCheckProvider_Google = 1,
        k_EContentCheckProvider_Amazon = 2,
        k_EContentCheckProvider_Local = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EProfileCustomizationType
    {
        k_EProfileCustomizationTypeInvalid = 0,
        k_EProfileCustomizationTypeRareAchievementShowcase = 1,
        k_EProfileCustomizationTypeGameCollector = 2,
        k_EProfileCustomizationTypeItemShowcase = 3,
        k_EProfileCustomizationTypeTradeShowcase = 4,
        k_EProfileCustomizationTypeBadges = 5,
        k_EProfileCustomizationTypeFavoriteGame = 6,
        k_EProfileCustomizationTypeScreenshotShowcase = 7,
        k_EProfileCustomizationTypeCustomText = 8,
        k_EProfileCustomizationTypeFavoriteGroup = 9,
        k_EProfileCustomizationTypeRecommendation = 10,
        k_EProfileCustomizationTypeWorkshopItem = 11,
        k_EProfileCustomizationTypeMyWorkshop = 12,
        k_EProfileCustomizationTypeArtworkShowcase = 13,
        k_EProfileCustomizationTypeVideoShowcase = 14,
        k_EProfileCustomizationTypeGuides = 15,
        k_EProfileCustomizationTypeMyGuides = 16,
        k_EProfileCustomizationTypeAchievements = 17,
        k_EProfileCustomizationTypeGreenlight = 18,
        k_EProfileCustomizationTypeMyGreenlight = 19,
        k_EProfileCustomizationTypeSalien = 20,
        k_EProfileCustomizationTypeLoyaltyRewardReactions = 21,
        k_EProfileCustomizationTypeSingleArtworkShowcase = 22,
        k_EProfileCustomizationTypeAchievementsCompletionist = 23,
        k_EProfileCustomizationTypeReplay = 24,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EPublishedFileStorageSystem
    {
        k_EPublishedFileStorageSystemInvalid = 0,
        k_EPublishedFileStorageSystemLegacyCloud = 1,
        k_EPublishedFileStorageSystemDepot = 2,
        k_EPublishedFileStorageSystemUGCCloud = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ECloudStoragePersistState
    {
        k_ECloudStoragePersistStatePersisted = 0,
        k_ECloudStoragePersistStateForgotten = 1,
        k_ECloudStoragePersistStateDeleted = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESDCardFormatStage
    {
        k_ESDCardFormatStage_Invalid = 0,
        k_ESDCardFormatStage_Starting = 1,
        k_ESDCardFormatStage_Testing = 2,
        k_ESDCardFormatStage_Rescuing = 3,
        k_ESDCardFormatStage_Formatting = 4,
        k_ESDCardFormatStage_Finalizing = 5,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESystemFanControlMode
    {
        k_SystemFanControlMode_Invalid = 0,
        k_SystemFanControlMode_Disabled = 1,
        k_SystemFanControlMode_Default = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EBluetoothDeviceType
    {
        k_BluetoothDeviceType_Invalid = 0,
        k_BluetoothDeviceType_Unknown = 1,
        k_BluetoothDeviceType_Phone = 2,
        k_BluetoothDeviceType_Computer = 3,
        k_BluetoothDeviceType_Headset = 4,
        k_BluetoothDeviceType_Headphones = 5,
        k_BluetoothDeviceType_Speakers = 6,
        k_BluetoothDeviceType_OtherAudio = 7,
        k_BluetoothDeviceType_Mouse = 8,
        k_BluetoothDeviceType_Joystick = 9,
        k_BluetoothDeviceType_Gamepad = 10,
        k_BluetoothDeviceType_Keyboard = 11,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESystemAudioDirection
    {
        k_SystemAudioDirection_Invalid = 0,
        k_SystemAudioDirection_Input = 1,
        k_SystemAudioDirection_Output = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESystemAudioChannel
    {
        k_SystemAudioChannel_Invalid = 0,
        k_SystemAudioChannel_Aggregated = 1,
        k_SystemAudioChannel_FrontLeft = 2,
        k_SystemAudioChannel_FrontRight = 3,
        k_SystemAudioChannel_LFE = 4,
        k_SystemAudioChannel_BackLeft = 5,
        k_SystemAudioChannel_BackRight = 6,
        k_SystemAudioChannel_FrontCenter = 7,
        k_SystemAudioChannel_Unknown = 8,
        k_SystemAudioChannel_Mono = 9,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESystemAudioPortType
    {
        k_SystemAudioPortType_Invalid = 0,
        k_SystemAudioPortType_Unknown = 1,
        k_SystemAudioPortType_Audio32f = 2,
        k_SystemAudioPortType_Midi8b = 3,
        k_SystemAudioPortType_Video32RGBA = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESystemAudioPortDirection
    {
        k_SystemAudioPortDirection_Invalid = 0,
        k_SystemAudioPortDirection_Input = 1,
        k_SystemAudioPortDirection_Output = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESystemServiceState
    {
        k_ESystemServiceState_Unavailable = 0,
        k_ESystemServiceState_Disabled = 1,
        k_ESystemServiceState_Enabled = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EGraphicsPerfOverlayLevel
    {
        k_EGraphicsPerfOverlayLevel_Hidden = 0,
        k_EGraphicsPerfOverlayLevel_Basic = 1,
        k_EGraphicsPerfOverlayLevel_Medium = 2,
        k_EGraphicsPerfOverlayLevel_Full = 3,
        k_EGraphicsPerfOverlayLevel_Minimal = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EGPUPerformanceLevel
    {
        k_EGPUPerformanceLevel_Invalid = 0,
        k_EGPUPerformanceLevel_Auto = 1,
        k_EGPUPerformanceLevel_Manual = 2,
        k_EGPUPerformanceLevel_Low = 3,
        k_EGPUPerformanceLevel_High = 4,
        k_EGPUPerformanceLevel_Profiling = 5,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EScalingFilter
    {
        k_EScalingFilter_Invalid = 0,
        k_EScalingFilter_FSR = 1,
        k_EScalingFilter_Nearest = 2,
        k_EScalingFilter_Integer = 3,
        k_EScalingFilter_Linear = 4,
        k_EScalingFilter_NIS = 5,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESplitScalingFilter
    {
        k_ESplitScalingFilter_Invalid = 0,
        k_ESplitScalingFilter_Linear = 1,
        k_ESplitScalingFilter_Nearest = 2,
        k_ESplitScalingFilter_FSR = 3,
        k_ESplitScalingFilter_NIS = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESplitScalingScaler
    {
        k_ESplitScalingScaler_Invalid = 0,
        k_ESplitScalingScaler_Auto = 1,
        k_ESplitScalingScaler_Integer = 2,
        k_ESplitScalingScaler_Fit = 3,
        k_ESplitScalingScaler_Fill = 4,
        k_ESplitScalingScaler_Stretch = 5,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EHDRToneMapOperator
    {
        k_EHDRToneMapOperator_Invalid = 0,
        k_EHDRToneMapOperator_Uncharted = 1,
        k_EHDRToneMapOperator_Reinhard = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ECPUGovernor
    {
        k_ECPUGovernor_Invalid = 0,
        k_ECPUGovernor_Perf = 1,
        k_ECPUGovernor_Powersave = 2,
        k_ECPUGovernor_Manual = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EUpdaterType
    {
        k_EUpdaterType_Invalid = 0,
        k_EUpdaterType_Client = 1,
        k_EUpdaterType_OS = 2,
        k_EUpdaterType_BIOS = 3,
        k_EUpdaterType_Aggregated = 4,
        k_EUpdaterType_Test1 = 5,
        k_EUpdaterType_Test2 = 6,
        k_EUpdaterType_Dummy = 7,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EUpdaterState
    {
        k_EUpdaterState_Invalid = 0,
        k_EUpdaterState_UpToDate = 2,
        k_EUpdaterState_Checking = 3,
        k_EUpdaterState_Available = 4,
        k_EUpdaterState_Applying = 5,
        k_EUpdaterState_ClientRestartPending = 6,
        k_EUpdaterState_SystemRestartPending = 7,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EStorageBlockContentType
    {
        k_EStorageBlockContentType_Invalid = 0,
        k_EStorageBlockContentType_Unknown = 1,
        k_EStorageBlockContentType_FileSystem = 2,
        k_EStorageBlockContentType_Crypto = 3,
        k_EStorageBlockContentType_Raid = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EStorageBlockFileSystemType
    {
        k_EStorageBlockFileSystemType_Invalid = 0,
        k_EStorageBlockFileSystemType_Unknown = 1,
        k_EStorageBlockFileSystemType_VFat = 2,
        k_EStorageBlockFileSystemType_Ext4 = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EStorageDriveMediaType
    {
        k_EStorageDriveMediaType_Invalid = 0,
        k_EStorageDriveMediaType_Unknown = 1,
        k_EStorageDriveMediaType_HDD = 2,
        k_EStorageDriveMediaType_SSD = 3,
        k_EStorageDriveMediaType_Removable = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESystemDisplayCompatibilityMode
    {
        k_ESystemDisplayCompatibilityMode_Invalid = 0,
        k_ESystemDisplayCompatibilityMode_None = 1,
        k_ESystemDisplayCompatibilityMode_MinimalBandwith = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESteamDeckCompatibilityCategory
    {
        k_ESteamDeckCompatibilityCategory_Unknown = 0,
        k_ESteamDeckCompatibilityCategory_Unsupported = 1,
        k_ESteamDeckCompatibilityCategory_Playable = 2,
        k_ESteamDeckCompatibilityCategory_Verified = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESteamDeckCompatibilityResultDisplayType
    {
        k_ESteamDeckCompatibilityResultDisplayType_Invisible = 0,
        k_ESteamDeckCompatibilityResultDisplayType_Informational = 1,
        k_ESteamDeckCompatibilityResultDisplayType_Unsupported = 2,
        k_ESteamDeckCompatibilityResultDisplayType_Playable = 3,
        k_ESteamDeckCompatibilityResultDisplayType_Verified = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EACState
    {
        k_EACState_Unknown = 0,
        k_EACState_Disconnected = 1,
        k_EACState_Connected = 2,
        k_EACState_ConnectedSlow = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EBatteryState
    {
        k_EBatteryState_Unknown = 0,
        k_EBatteryState_Discharging = 1,
        k_EBatteryState_Charging = 2,
        k_EBatteryState_Full = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EOSBranch
    {
        k_EOSBranch_Unknown = 0,
        k_EOSBranch_Release = 1,
        k_EOSBranch_ReleaseCandidate = 2,
        k_EOSBranch_Beta = 3,
        k_EOSBranch_BetaCandidate = 4,
        k_EOSBranch_Main = 5,
        k_EOSBranch_Staging = 6,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ECommunityItemClass
    {
        k_ECommunityItemClass_Invalid = 0,
        k_ECommunityItemClass_Badge = 1,
        k_ECommunityItemClass_GameCard = 2,
        k_ECommunityItemClass_ProfileBackground = 3,
        k_ECommunityItemClass_Emoticon = 4,
        k_ECommunityItemClass_BoosterPack = 5,
        k_ECommunityItemClass_Consumable = 6,
        k_ECommunityItemClass_GameGoo = 7,
        k_ECommunityItemClass_ProfileModifier = 8,
        k_ECommunityItemClass_Scene = 9,
        k_ECommunityItemClass_SalienItem = 10,
        k_ECommunityItemClass_Sticker = 11,
        k_ECommunityItemClass_ChatEffect = 12,
        k_ECommunityItemClass_MiniProfileBackground = 13,
        k_ECommunityItemClass_AvatarFrame = 14,
        k_ECommunityItemClass_AnimatedAvatar = 15,
        k_ECommunityItemClass_SteamDeckKeyboardSkin = 16,
        k_ECommunityItemClass_SteamDeckStartupMovie = 17,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESteamDeckCompatibilityFeedback
    {
        k_ESteamDeckCompatibilityFeedback_Unset = 0,
        k_ESteamDeckCompatibilityFeedback_Agree = 1,
        k_ESteamDeckCompatibilityFeedback_Disagree = 2,
        k_ESteamDeckCompatibilityFeedback_Ignore = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EProvideDeckFeedbackPreference
    {
        k_EProvideDeckFeedbackPreference_Unset = 0,
        k_EProvideDeckFeedbackPreference_Yes = 1,
        k_EProvideDeckFeedbackPreference_No = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ETouchGesture
    {
        k_ETouchGestureNone = 0,
        k_ETouchGestureTouch = 1,
        k_ETouchGestureTap = 2,
        k_ETouchGestureDoubleTap = 3,
        k_ETouchGestureShortPress = 4,
        k_ETouchGestureLongPress = 5,
        k_ETouchGestureLongTap = 6,
        k_ETouchGestureTwoFingerTap = 7,
        k_ETouchGestureTapCancelled = 8,
        k_ETouchGesturePinchBegin = 9,
        k_ETouchGesturePinchUpdate = 10,
        k_ETouchGesturePinchEnd = 11,
        k_ETouchGestureFlingStart = 12,
        k_ETouchGestureFlingCancelled = 13,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESessionPersistence
    {
        k_ESessionPersistence_Invalid = -1,
        k_ESessionPersistence_Ephemeral = 0,
        k_ESessionPersistence_Persistent = 1,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ENewSteamAnnouncementState
    {
        k_ENewSteamAnnouncementState_Invalid = 0,
        k_ENewSteamAnnouncementState_AllRead = 1,
        k_ENewSteamAnnouncementState_NewAnnouncement = 2,
        k_ENewSteamAnnouncementState_FeaturedAnnouncement = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ECommentThreadType
    {
        k_ECommentThreadTypeInvalid = 0,
        k_ECommentThreadTypeScreenshot_Deprecated = 1,
        k_ECommentThreadTypeWorkshopAccount_Developer = 2,
        k_ECommentThreadTypeWorkshopAccount_Public = 3,
        k_ECommentThreadTypePublishedFile_Developer = 4,
        k_ECommentThreadTypePublishedFile_Public = 5,
        k_ECommentThreadTypeTest = 6,
        k_ECommentThreadTypeForumTopic = 7,
        k_ECommentThreadTypeRecommendation = 8,
        k_ECommentThreadTypeVideo_Deprecated = 9,
        k_ECommentThreadTypeProfile = 10,
        k_ECommentThreadTypeNewsPost = 11,
        k_ECommentThreadTypeClan = 12,
        k_ECommentThreadTypeClanAnnouncement = 13,
        k_ECommentThreadTypeClanEvent = 14,
        k_ECommentThreadTypeUserStatusPublished = 15,
        k_ECommentThreadTypeUserReceivedNewGame = 16,
        k_ECommentThreadTypePublishedFile_Announcement = 17,
        k_ECommentThreadTypeModeratorMessage = 18,
        k_ECommentThreadTypeClanCuratedApp = 19,
        k_ECommentThreadTypeQAndASession = 20,
        k_ECommentThreadTypeMax = 21,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EBroadcastPermission
    {
        k_EBroadcastPermissionDisabled = 0,
        k_EBroadcastPermissionFriendsApprove = 1,
        k_EBroadcastPermissionFriendsAllowed = 2,
        k_EBroadcastPermissionPublic = 3,
        k_EBroadcastPermissionSubscribers = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EBroadcastEncoderSetting
    {
        k_EBroadcastEncoderBestQuality = 0,
        k_EBroadcastEncoderBestPerformance = 1,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ECloudGamingPlatform
    {
        k_ECloudGamingPlatformNone = 0,
        k_ECloudGamingPlatformValve = 1,
        k_ECloudGamingPlatformNVIDIA = 2,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
