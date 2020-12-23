using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Outgoing
{
    public static class OutgoingPacketsHeader
    {
        public const ushort PetStatusUpdateComposer = 1907;//error 404

        public const ushort CfhTopicsMessageComposer = 325;
        public const ushort FavoriteRoomsCountComposer = 151;
        public const ushort UserCurrencyComposer = 2018;
        public const ushort RedeemVoucherOKComposer = 3336;
        public const ushort RoomUserShoutComposer = 1036;
        public const ushort RoomUserStatusComposer = 1640;
        public const ushort RoomUserDataComposer = 3920;
        public const ushort RoomAddRightsListComposer = 2088;
        public const ushort RoomRemoveRightsListComposer = 1327;
        public const ushort RoomRightsListComposer = 1284;
        public const ushort RoomUserHandItemComposer = 1474;
        public const ushort RoomUsersComposer = 374;
        public const ushort FriendRequestComposer = 2219;
        public const ushort GuildBoughtComposer = 2808;
        public const ushort AddUserBadgeComposer = 2493;
        public const ushort RecyclerCompleteComposer = 468;
        public const ushort GuildBuyRoomsComposer = 2159;
        public const ushort FriendsComposer = 3130;
        public const ushort StalkErrorComposer = 3048;
        public const ushort TradeCloseWindowComposer = 1001;
        public const ushort RemoveFloorItemComposer = 2703;
        public const ushort InventoryPetsComposer = 3522;
        public const ushort UserCreditsComposer = 3475;
        public const ushort WiredTriggerDataComposer = 383;
        public const ushort TradeStoppedComposer = 1373;
        public const ushort ModToolUserChatlogComposer = 3377;
        public const ushort GuildInfoComposer = 1702;
        public const ushort UserPermissionsComposer = 411;
        public const ushort PetNameErrorComposer = 1503;
        public const ushort TradeStartFailComposer = 217;
        public const ushort AddHabboItemComposer = 2103;
        public const ushort InventoryBotsComposer = 3086;
        public const ushort CanCreateRoomComposer = 378;
        public const ushort MarketplaceBuyErrorComposer = 2032;
        public const ushort BonusRareComposer = 1533;
        public const ushort HotelViewComposer = 122;
        public const ushort UpdateFriendComposer = 2800;
        public const ushort FloorItemUpdateComposer = 3776;
        public const ushort RoomAccessDeniedComposer = 878;
        public const ushort GuildFurniWidgetComposer = 3293;
        public const ushort GiftConfigurationComposer = 2234;
        public const ushort UserClubComposer = 954;
        public const ushort InventoryBadgesComposer = 717;
        public const ushort RoomUserTypingComposer = 1717;
        public const ushort GuildJoinErrorComposer = 762;
        public const ushort RoomCategoriesComposer = 1562;
        public const ushort InventoryAchievementsComposer = 2501;
        public const ushort MarketplaceItemInfoComposer = 725;
        public const ushort RoomRelativeMapComposer = 2753;
        public const ushort ModToolComposerTwo = 2335;
        public const ushort ModToolComposerOne = 3192;
        public const ushort RoomRightsComposer = 780;
        public const ushort ObjectOnRollerComposer = 3207;
        public const ushort PollStartComposer = 3785;
        public const ushort GuildRefreshMembersListComposer = 2445;
        public const ushort UserPerksComposer = 2586;
        public const ushort UserCitizinShipComposer = 1203;
        public const ushort PublicRoomsComposer = ushort.MinValue;//error 404
        public const ushort MarketplaceOffersComposer = 680;
        public const ushort ModToolComposer = 2696;
        public const ushort UserBadgesComposer = 1087;
        public const ushort GuildManageComposer = 3965;
        public const ushort RemoveFriendComposer = ushort.MinValue;//error 404
        public const ushort InitDiffieHandshakeComposer = 1347;
        public const ushort CompleteDiffieHandshakeComposer = 3885;
        public const ushort UserDataComposer = 2725;
        public const ushort UserSearchResultComposer = 973;
        public const ushort ModToolUserRoomVisitsComposer = 1752;
        public const ushort RoomUserRespectComposer = 2815;
        public const ushort RoomChatSettingsComposer = 1191;
        public const ushort RemoveHabboItemComposer = 159;
        public const ushort RoomUserRemoveComposer = 2661;
        public const ushort RoomHeightMapComposer = 1301;
        public const ushort RoomPetHorseFigureComposer = 1924;
        public const ushort PetErrorComposer = 2913;
        public const ushort TradeUpdateComposer = 2024;
        public const ushort PrivateRoomsComposer = 52;
        public const ushort RoomModelComposer = 2031;
        public const ushort RoomScoreComposer = 482;
        public const ushort DoorbellAddUserComposer = 2309;
        public const ushort SecureLoginOKComposer = 2491;
        public const ushort SessionRightsComposer = 2033;
        public const ushort GuildMemberUpdateComposer = 265;
        public const ushort RoomFloorItemsComposer = 1778;
        public const ushort InventoryItemsComposer = 994;
        public const ushort RoomUserTalkComposer = 1446;
        public const ushort TradeStartComposer = 2505;
        public const ushort InventoryItemUpdateComposer = 104;
        public const ushort ModToolIssueUpdateComposer = 3150;
        public const ushort MeMenuSettingsComposer = 513;
        public const ushort ModToolRoomInfoComposer = 1333;
        public const ushort GuildListComposer = 420;
        public const ushort RecyclerLogicComposer = 3164;
        public const ushort UserHomeRoomComposer = 2875;
        public const ushort RoomUserDanceComposer = 2233;
        public const ushort RoomSettingsUpdatedComposer = 3297;
        public const ushort AlertPurchaseFailedComposer = 1404;
        public const ushort RoomDataComposer = 687;
        public const ushort TagsComposer = 2012;
        public const ushort InventoryRefreshComposer = 3151; // PRODUCTION-201611291003-338511768
        public const ushort RemovePetComposer = 3253; // PRODUCTION-201611291003-338511768
        public const ushort RemoveWallItemComposer = 3208; // PRODUCTION-201611291003-338511768
        public const ushort TradeCompleteComposer = 2369; // PRODUCTION-201611291003-338511768
        public const ushort NewsWidgetsComposer = 286; // PRODUCTION-201611291003-338511768
        public const ushort WiredEffectDataComposer = 1434; // PRODUCTION-201611291003-338511768
        public const ushort BubbleAlertComposer = 1992; // PRODUCTION-201611291003-338511768
        public const ushort ReloadRecyclerComposer = 3433; // PRODUCTION-201611291003-338511768
        public const ushort MoodLightDataComposer = 2710; // PRODUCTION-201611291003-338511768
        public const ushort WiredRewardAlertComposer = 178; // PRODUCTION-201611291003-338511768
        public const ushort CatalogPageComposer = 804; // PRODUCTION-201611291003-338511768
        public const ushort CatalogModeComposer = 3828; // PRODUCTION-201611291003-338511768
        public const ushort ChangeNameUpdateComposer = 118; // PRODUCTION-201611291003-338511768
        public const ushort AddFloorItemComposer = 1534; // PRODUCTION-201611291003-338511768
        public const ushort DebugConsoleComposer = 3284; // PRODUCTION-201611291003-338511768
        public const ushort HallOfFameComposer = 3005; // PRODUCTION-201611291003-338511768
        public const ushort WiredSavedComposer = 1155; // PRODUCTION-201611291003-338511768
        public const ushort RoomPaintComposer = 2454; // PRODUCTION-201611291003-338511768
        public const ushort MarketplaceConfigComposer = 1823; // PRODUCTION-201611291003-338511768
        public const ushort AddBotComposer = 1352; // PRODUCTION-201611291003-338511768
        public const ushort FriendRequestErrorComposer = 892; // PRODUCTION-201611291003-338511768
        public const ushort GuildMembersComposer = 1200; // PRODUCTION-201611291003-338511768
        public const ushort RoomOpenComposer = 758; // PRODUCTION-201611291003-338511768
        public const ushort ModToolRoomChatlogComposer = 3434; // PRODUCTION-201611291003-338511768
        public const ushort DiscountComposer = 2347; // PRODUCTION-201611291003-338511768
        public const ushort MarketplaceCancelSaleComposer = 3264; // PRODUCTION-201611291003-338511768
        public const ushort RoomPetRespectComposer = 2788; // PRODUCTION-201611291003-338511768
        public const ushort RoomSettingsComposer = 1498; // PRODUCTION-201611291003-338511768
        public const ushort TalentTrackComposer = 3406; // PRODUCTION-201611291003-338511768
        public const ushort CatalogPagesListComposer = 1032; // PRODUCTION-201611291003-338511768
        public const ushort AlertLimitedSoldOutComposer = 377; // PRODUCTION-201611291003-338511768
        public const ushort CatalogUpdatedComposer = 1866; // PRODUCTION-201611291003-338511768
        public const ushort PurchaseOKComposer = 869; // PRODUCTION-201611291003-338511768
        public const ushort WallItemUpdateComposer = 2009; // PRODUCTION-201611291003-338511768
        public const ushort TradeAcceptedComposer = 2568; // PRODUCTION-201611291003-338511768
        public const ushort AddWallItemComposer = 2187; // PRODUCTION-201611291003-338511768
        public const ushort RoomEntryInfoComposer = ushort.MinValue; // PRODUCTION-201611291003-338511768
        public const ushort HotelViewDataComposer = 1745; // PRODUCTION-201611291003-338511768
        public const ushort PresentItemOpenedComposer = 56; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserRemoveRightsComposer = 84; // PRODUCTION-201611291003-338511768
        public const ushort UserBCLimitsComposer = ushort.MinValue; // PRODUCTION-201611291003-338511768
        public const ushort PetTrainingPanelComposer = 1164; // PRODUCTION-201611291003-338511768
        public const ushort RoomPaneComposer = 749; // PRODUCTION-201611291003-338511768
        public const ushort RedeemVoucherErrorComposer = 714; // PRODUCTION-201611291003-338511768
        public const ushort RoomCreatedComposer = 1304; // PRODUCTION-201611291003-338511768
        public const ushort GenericAlertComposer = 3801; // PRODUCTION-201611291003-338511768
        public const ushort GroupPartsComposer = 2238; // PRODUCTION-201611291003-338511768
        public const ushort ModToolIssueInfoComposer = 3609; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserWhisperComposer = 2704; // PRODUCTION-201611291003-338511768
        public const ushort BotErrorComposer = 639; // PRODUCTION-201611291003-338511768
        public const ushort FreezeLivesComposer = 2324; // PRODUCTION-201611291003-338511768
        public const ushort LoadFriendRequestsComposer = 280; // PRODUCTION-201611291003-338511768
        public const ushort MarketplaceSellItemComposer = 54; // PRODUCTION-201611291003-338511768
        public const ushort ClubDataComposer = 2405; // PRODUCTION-201611291003-338511768
        public const ushort ProfileFriendsComposer = 2016; // PRODUCTION-201611291003-338511768
        public const ushort MarketplaceOwnItemsComposer = 3884; // PRODUCTION-201611291003-338511768
        public const ushort RoomOwnerComposer = 339; // PRODUCTION-201611291003-338511768
        public const ushort WiredConditionDataComposer = 1108; // PRODUCTION-201611291003-338511768
        public const ushort ModToolUserInfoComposer = 2866; // PRODUCTION-201611291003-338511768
        public const ushort UserWardrobeComposer = 3315; // PRODUCTION-201611291003-338511768
        public const ushort RoomPetExperienceComposer = 2156; // PRODUCTION-201611291003-338511768
        public const ushort FriendChatMessageComposer = 1587; // PRODUCTION-201611291003-338511768
        public const ushort PetInformationComposer = 2901; // PRODUCTION-201611291003-338511768
        public const ushort RoomThicknessComposer = 3547; // PRODUCTION-201611291003-338511768
        public const ushort AddPetComposer = 2101; // PRODUCTION-201611291003-338511768
        public const ushort UpdateStackHeightComposer = 558; // PRODUCTION-201611291003-338511768
        public const ushort RemoveBotComposer = 233; // PRODUCTION-201611291003-338511768
        public const ushort RoomEnterErrorComposer = 899; // PRODUCTION-201611291003-338511768
        public const ushort PollQuestionsComposer = 2997; // PRODUCTION-201611291003-338511768
        public const ushort GenericErrorMessages = 1600; // PRODUCTION-201611291003-338511768
        public const ushort RoomWallItemsComposer = 1369; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserEffectComposer = 1167; // PRODUCTION-201611291003-338511768
        public const ushort PetBreedsComposer = 3331; // PRODUCTION-201611291003-338511768
        public const ushort ModToolIssueChatlogComposer = 607; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserActionComposer = 1631; // PRODUCTION-201611291003-338511768
        public const ushort BotSettingsComposer = 1618; // PRODUCTION-201611291003-338511768
        public const ushort UserProfileComposer = 3898; // PRODUCTION-201611291003-338511768
        public const ushort MinimailCountComposer = 2803; // PRODUCTION-201611291003-338511768
        public const ushort UserAchievementScoreComposer = 1968; // PRODUCTION-201611291003-338511768
        public const ushort PetLevelUpComposer = 859; // PRODUCTION-201611291003-338511768
        public const ushort UserPointsComposer = 2275; // PRODUCTION-201611291003-338511768
        public const ushort ReportRoomFormComposer = 1121; // PRODUCTION-201611291003-338511768
        public const ushort ModToolIssueHandledComposer = 934; // PRODUCTION-201611291003-338511768
        public const ushort FloodCounterComposer = 566; // PRODUCTION-201611291003-338511768
        public const ushort UpdateFailedComposer = 156; // PRODUCTION-201611291003-338511768
        public const ushort FloorPlanEditorDoorSettingsComposer = 1664; // PRODUCTION-201611291003-338511768
        public const ushort FloorPlanEditorBlockedTilesComposer = 3990; // PRODUCTION-201611291003-338511768
        public const ushort BuildersClubExpiredComposer = 1452; // PRODUCTION-201611291003-338511768
        public const ushort RoomSettingsSavedComposer = 948; // PRODUCTION-201611291003-338511768
        public const ushort MessengerInitComposer = 1605; // PRODUCTION-201611291003-338511768
        public const ushort UserClothesComposer = 1450; // PRODUCTION-201611291003-338511768
        public const ushort UserEffectsListComposer = 340; // PRODUCTION-201611291003-338511768
        public const ushort NewUserIdentityComposer = 3738; // PRODUCTION-201611291003-338511768
        public const ushort NewNavigatorEventCategoriesComposer = 3244; // PRODUCTION-201611291003-338511768
        public const ushort NewNavigatorCollapsedCategoriesComposer = 1543; // PRODUCTION-201611291003-338511768
        public const ushort NewNavigatorLiftedRoomsComposer = 3104; // PRODUCTION-201611291003-338511768
        public const ushort NewNavigatorSavedSearchesComposer = 3984; // PRODUCTION-201611291003-338511768
        public const ushort PostItDataComposer = 2202; // PRODUCTION-201611291003-338511768
        public const ushort ModToolReportReceivedAlertComposer = 3635; // PRODUCTION-201611291003-338511768
        public const ushort ModToolIssueResponseAlertComposer = 3796; // PRODUCTION-201611291003-338511768
        public const ushort AchievementListComposer = 305; // PRODUCTION-201611291003-338511768
        public const ushort AchievementProgressComposer = 2107; // PRODUCTION-201611291003-338511768
        public const ushort AchievementUnlockedComposer = 806; // PRODUCTION-201611291003-338511768
        public const ushort ClubGiftsComposer = 619; // PRODUCTION-201611291003-338511768
        public const ushort MachineIDComposer = 1488; // PRODUCTION-201611291003-338511768
        public const ushort PongComposer = 10; // PRODUCTION-201611291003-338511768
        public const ushort ModToolIssueHandlerDimensionsComposer = 1576; // PRODUCTION-201611291003-338511768

        //Uknown but work
        public const ushort IsFirstLoginOfDayComposer = 793; // PRODUCTION-201611291003-338511768 //Quest Engine
        public const ushort UnknownComposer5 = 2833; // PRODUCTION-201611291003-338511768 //Mysterbox
        public const ushort IgnoredUsersComposer = 126; // PRODUCTION-201611291003-338511768
        public const ushort NewNavigatorMetaDataComposer = 3052; // PRODUCTION-201611291003-338511768
        public const ushort NewNavigatorSearchResultsComposer = 2690; // PRODUCTION-201611291003-338511768
        public const ushort MysticBoxStartOpenComposer = 3201; // PRODUCTION-201611291003-338511768
        public const ushort MysticBoxCloseComposer = 596; // PRODUCTION-201611291003-338511768
        public const ushort MysticBoxPrizeComposer = 3712; // PRODUCTION-201611291003-338511768
        public const ushort RentableSpaceInfoComposer = 3559; // PRODUCTION-201611291003-338511768
        public const ushort RentableSpaceUnknownComposer = 2046; // PRODUCTION-201611291003-338511768
        public const ushort RentableSpaceUnknown2Composer = 1868; // PRODUCTION-201611291003-338511768
        public const ushort GuildConfirmRemoveMemberComposer = 1876; // PRODUCTION-201611291003-338511768

        public const ushort HotelViewBadgeButtonConfigComposer = 2998; // PRODUCTION-201611291003-338511768
        public const ushort EpicPopupFrameComposer = 3945; // PRODUCTION-201611291003-338511768
        public const ushort BaseJumpLoadGameURLComposer = 2624; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserTagsComposer = 1255; // PRODUCTION-201611291003-338511768
        public const ushort RoomInviteErrorComposer = 462; // PRODUCTION-201611291003-338511768
        public const ushort PostItStickyPoleOpenComposer = 2366; // PRODUCTION-201611291003-338511768
        public const ushort NewYearResolutionProgressComposer = 3370; // PRODUCTION-201611291003-338511768
        public const ushort ClubGiftReceivedComposer = 659; // PRODUCTION-201611291003-338511768
        public const ushort ItemStateComposer = 2376; // PRODUCTION-201611291003-338511768
        public const ushort ItemExtraDataComposer = 2547; // PRODUCTION-201611291003-338511768
        public const ushort PostUpdateMessageComposer = 324; // PRODUCTION-201611291003-338511768
                                                                 //NotSure Needs Testing
        public const ushort QuestionInfoComposer = ushort.MinValue; // PRODUCTION-201611291003-338511768
        public const ushort TalentTrackEmailVerifiedComposer = 612; // PRODUCTION-201611291003-338511768
        public const ushort TalentTrackEmailFailedComposer = 1815; // PRODUCTION-201611291003-338511768
        public const ushort UnknownAvatarEditorComposer = 3473; // PRODUCTION-201611291003-338511768

        public const ushort GuildMembershipRequestedComposer = 1180; // PRODUCTION-201611291003-338511768

        public const ushort GuildForumsUnreadMessagesCountComposer = 2379; // PRODUCTION-201611291003-338511768
        public const ushort GuildForumThreadMessagesComposer = 1862; // PRODUCTION-201611291003-338511768
        public const ushort GuildForumAddCommentComposer = 2049; // PRODUCTION-201611291003-338511768
        public const ushort GuildForumDataComposer = 3011; // PRODUCTION-201611291003-338511768
        public const ushort GuildForumCommentsComposer = 509; // PRODUCTION-201611291003-338511768
        public const ushort UnknownGuildForumComposer6 = ushort.MinValue; // PRODUCTION-201611291003-338511768
        public const ushort UnknownGuildForumComposer7 = ushort.MinValue; // PRODUCTION-201611291003-338511768
        public const ushort GuildForumThreadsComposer = 1073; // PRODUCTION-201611291003-338511768
        public const ushort GuildForumListComposer = 3001; // PRODUCTION-201611291003-338511768
        public const ushort ThreadUpdateMessageComposer = 2528;
        public const ushort GuideSessionAttachedComposer = 1591; // PRODUCTION-201611291003-338511768
        public const ushort GuideSessionDetachedComposer = 138; // PRODUCTION-201611291003-338511768
        public const ushort GuideSessionStartedComposer = 3209; // PRODUCTION-201611291003-338511768
        public const ushort GuideSessionEndedComposer = 1456; // PRODUCTION-201611291003-338511768
        public const ushort GuideSessionErrorComposer = 673; // PRODUCTION-201611291003-338511768
        public const ushort GuideSessionMessageComposer = 841; // PRODUCTION-201611291003-338511768
        public const ushort GuideSessionRequesterRoomComposer = 1847; // PRODUCTION-201611291003-338511768
        public const ushort GuideSessionInvitedToGuideRoomComposer = 219; // PRODUCTION-201611291003-338511768
        public const ushort GuideSessionPartnerIsTypingComposer = 1016; // PRODUCTION-201611291003-338511768

        public const ushort GuideToolsComposer = 1548; // PRODUCTION-201611291003-338511768
        public const ushort GuardianNewReportReceivedComposer = 735; // PRODUCTION-201611291003-338511768
        public const ushort GuardianVotingRequestedComposer = 143; // PRODUCTION-201611291003-338511768
        public const ushort GuardianVotingVotesComposer = 1829; // PRODUCTION-201611291003-338511768
        public const ushort GuardianVotingResultComposer = 3276; // PRODUCTION-201611291003-338511768
        public const ushort GuardianVotingTimeEnded = 30; // PRODUCTION-201611291003-338511768

        public const ushort RoomMutedComposer = 2533; // PRODUCTION-201611291003-338511768

        public const ushort HideDoorbellComposer = 3783; // PRODUCTION-201611291003-338511768
        public const ushort RoomQueueStatusMessage = 2208; // PRODUCTION-201611291003-338511768
        public const ushort RoomUnknown3Composer = 1033; // PRODUCTION-201611291003-338511768

        public const ushort EffectsListRemoveComposer = 2228; // PRODUCTION-201611291003-338511768

        public const ushort OldPublicRoomsComposer = 2726; // PRODUCTION-201611291003-338511768
        public const ushort ItemStateComposer2 = 3431; // PRODUCTION-201611291003-338511768

        public const ushort HotelWillCloseInMinutesComposer = 1050; // PRODUCTION-201611291003-338511768
        public const ushort HotelWillCloseInMinutesAndBackInComposer = 1350; // PRODUCTION-201611291003-338511768
        public const ushort HotelClosesAndWillOpenAtComposer = 2771; // PRODUCTION-201611291003-338511768
        public const ushort HotelClosedAndOpensComposer = 3728; // PRODUCTION-201611291003-338511768
        public const ushort StaffAlertAndOpenHabboWayComposer = 1683; // PRODUCTION-201611291003-338511768
        public const ushort StaffAlertWithLinkComposer = 2030; // PRODUCTION-201611291003-338511768
        public const ushort StaffAlertWIthLinkAndOpenHabboWayComposer = 1890; // PRODUCTION-201611291003-338511768

        public const ushort RoomMessagesPostedCountComposer = 1634; // PRODUCTION-201611291003-338511768
        public const ushort CantScratchPetNotOldEnoughComposer = 1130; // PRODUCTION-201611291003-338511768
        public const ushort PetBoughtNotificationComposer = 1111; // PRODUCTION-201611291003-338511768
        public const ushort MessagesForYouComposer = 2035; // PRODUCTION-201611291003-338511768
        public const ushort UnknownStatusComposer = 1243; // PRODUCTION-201611291003-338511768
        public const ushort CloseWebPageComposer = 426; // PRODUCTION-201611291003-338511768
        public const ushort PickMonthlyClubGiftNotificationComposer = 2188; // PRODUCTION-201611291003-338511768
        public const ushort RemoveGuildFromRoomComposer = 3129; // PRODUCTION-201611291003-338511768
        public const ushort RoomBannedUsersComposer = 1869; // PRODUCTION-201611291003-338511768
        public const ushort OpenRoomCreationWindowComposer = 2064; // PRODUCTION-201611291003-338511768
        public const ushort ItemsDataUpdateComposer = 1453; // PRODUCTION-201611291003-338511768
        public const ushort WelcomeGiftComposer = 2707; // PRODUCTION-201611291003-338511768
        public const ushort SimplePollStartComposer = 2665; // PRODUCTION-201611291003-338511768
        public const ushort RoomNoRightsComposer = 2392; // PRODUCTION-201611291003-338511768
        public const ushort GuildEditFailComposer = 3988; // PRODUCTION-201611291003-338511768
        public const ushort MinimailNewMessageComposer = 1911; // PRODUCTION-201611291003-338511768
        public const ushort RoomFilterWordsComposer = 2937; // PRODUCTION-201611291003-338511768
        public const ushort VerifyMobileNumberComposer = 3639; // PRODUCTION-201611291003-338511768
        public const ushort NewUserGiftComposer = 3575; // PRODUCTION-201611291003-338511768
        public const ushort UpdateUserLookComposer = 2429; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserIgnoredComposer = 207; // PRODUCTION-201611291003-338511768
        public const ushort PetBreedingFailedComposer = 1625; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserNameChangedComposer = 2182; // PRODUCTION-201611291003-338511768
        public const ushort LoveLockFurniStartComposer = 3753; // PRODUCTION-201611291003-338511768
        public const ushort LoveLockFurniFriendConfirmedComposer = 382; // PRODUCTION-201611291003-338511768
        public const ushort LoveLockFurniFinishedComposer = 770; // PRODUCTION-201611291003-338511768
        public const ushort PetPackageNameValidationComposer = 546; // PRODUCTION-201611291003-338511768
        public const ushort GameCenterFeaturedPlayersComposer = 3097; // PRODUCTION-201611291003-338511768
        public const ushort HabboMallComposer = 1237; // PRODUCTION-201611291003-338511768
        public const ushort TargetedOfferComposer = 119; // PRODUCTION-201611291003-338511768
        public const ushort LeprechaunStarterBundleComposer = 2380; // PRODUCTION-201611291003-338511768
        public const ushort VerifyMobilePhoneWindowComposer = 2890; // PRODUCTION-201611291003-338511768
        public const ushort VerifyMobilePhoneCodeWindowComposer = 800; // PRODUCTION-201611291003-338511768
        public const ushort VerifyMobilePhoneDoneComposer = 91; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserReceivedHandItemComposer = 354; // PRODUCTION-201611291003-338511768
        public const ushort MutedWhisperComposer = 826; // PRODUCTION-201611291003-338511768
        public const ushort UnknownHintComposer = 1787; // PRODUCTION-201611291003-338511768
        public const ushort BullyReportClosedComposer = 2674; // PRODUCTION-201611291003-338511768
        public const ushort PromoteOwnRoomsListComposer = 2468; // PRODUCTION-201611291003-338511768
        public const ushort NotEnoughPointsTypeComposer = 3914; // PRODUCTION-201611291003-338511768
        public const ushort WatchAndEarnRewardComposer = 2125; // PRODUCTION-201611291003-338511768
        public const ushort NewYearResolutionComposer = 66; // PRODUCTION-201611291003-338511768
        public const ushort WelcomeGiftErrorComposer = 2293; // PRODUCTION-201611291003-338511768
        public const ushort RentableItemBuyOutPriceComposer = 35; // PRODUCTION-201611291003-338511768
        public const ushort VipTutorialsStartComposer = 2278; // PRODUCTION-201611291003-338511768
        public const ushort NewNavigatorCategoryUserCountComposer = 1455; // PRODUCTION-201611291003-338511768
        public const ushort CameraRoomThumbnailSavedComposer = 3595; // PRODUCTION-201611291003-338511768
        public const ushort RoomEditSettingsErrorComposer = 1555; // PRODUCTION-201611291003-338511768
        public const ushort GuildAcceptMemberErrorComposer = 818; // PRODUCTION-201611291003-338511768
        public const ushort MostUselessErrorAlertComposer = 662; // PRODUCTION-201611291003-338511768
        public const ushort AchievementsConfigurationComposer = 1689; // PRODUCTION-201611291003-338511768
        public const ushort PetBreedingResultComposer = 634; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserQuestionAnsweredComposer = ushort.MinValue; // PRODUCTION-201611291003-338511768
        public const ushort PetBreedingStartComposer = 1746; // PRODUCTION-201611291003-338511768
        public const ushort CustomNotificationComposer = 909; // PRODUCTION-201611291003-338511768
        public const ushort UpdateStackHeightTileHeightComposer = 2816; // PRODUCTION-201611291003-338511768
        public const ushort HotelViewCustomTimerComposer = ushort.MinValue; // PRODUCTION-201611291003-338511768
        public const ushort MarketplaceItemPostedComposer = 1359; // PRODUCTION-201611291003-338511768
        public const ushort HabboWayQuizComposer2 = 2927; // PRODUCTION-201611291003-338511768
        public const ushort GuildFavoriteRoomUserUpdateComposer = 3403; // PRODUCTION-201611291003-338511768
        public const ushort RoomAdErrorComposer = 1759; // PRODUCTION-201611291003-338511768
        public const ushort NewNavigatorSettingsComposer = 518; // PRODUCTION-201611291003-338511768
        public const ushort CameraPublishWaitMessageComposer = 2057; // PRODUCTION-201611291003-338511768
        public const ushort RoomInviteComposer = 3870; // PRODUCTION-201611291003-338511768
        public const ushort BullyReportRequestComposer = 3463; // PRODUCTION-201611291003-338511768
        public const ushort UnknownHelperComposer = 77; // PRODUCTION-201611291003-338511768
        public const ushort HelperRequestDisabledComposer = 1651; // PRODUCTION-201611291003-338511768
        public const ushort RoomUnitIdleComposer = 1797; // PRODUCTION-201611291003-338511768
        public const ushort QuestCompletedComposer = 949; // PRODUCTION-201611291003-338511768
        public const ushort UnkownPetPackageComposer = 1723; // PRODUCTION-201611291003-338511768
        public const ushort ForwardToRoomComposer = 160; // PRODUCTION-201611291003-338511768
        public const ushort EffectsListEffectEnableComposer = 1959; // PRODUCTION-201611291003-338511768
        public const ushort CompetitionEntrySubmitResultComposer = 1177; // PRODUCTION-201611291003-338511768
        public const ushort ExtendClubMessageComposer = 3964; // PRODUCTION-201611291003-338511768
        public const ushort HotelViewConcurrentUsersComposer = 2737; // PRODUCTION-201611291003-338511768
        public const ushort InventoryAddEffectComposer = ushort.MinValue;//error 404
        public const ushort TalentLevelUpdateComposer = 638; // PRODUCTION-201611291003-338511768
        public const ushort BullyReportedMessageComposer = 3285; // PRODUCTION-201611291003-338511768
        public const ushort UnknownQuestComposer3 = 1122; // PRODUCTION-201611291003-338511768
        public const ushort FriendToolbarNotificationComposer = 3082; // PRODUCTION-201611291003-338511768
        public const ushort MessengerErrorComposer = 896; // PRODUCTION-201611291003-338511768
        public const ushort CameraPriceComposer = 3878; // PRODUCTION-201611291003-338511768
        public const ushort PetBreedingCompleted = 2527; // PRODUCTION-201611291003-338511768
        public const ushort RoomUserUnbannedComposer = 3429; // PRODUCTION-201611291003-338511768
        public const ushort HotelViewCommunityGoalComposer = 2525; // PRODUCTION-201611291003-338511768
        public const ushort UserClassificationComposer = 966; // PRODUCTION-201611291003-338511768
        public const ushort CanCreateEventComposer = 2599; // PRODUCTION-201611291003-338511768
        public const ushort UnknownGuild2Composer = 1459; // PRODUCTION-201611291003-338511768
        public const ushort YoutubeDisplayListComposer = 1112; // PRODUCTION-201611291003-338511768
        public const ushort YoutubeMessageComposer2 = 1411; // PRODUCTION-201611291003-338511768
        public const ushort YoutubeMessageComposer3 = 1554; // PRODUCTION-201611291003-338511768
        public const ushort RoomCategoryUpdateMessageComposer = 3896; // PRODUCTION-201611291003-338511768
        public const ushort QuestsComposer = 3625; // PRODUCTION-201611291003-338511768
        public const ushort GiftReceiverNotFoundComposer = 1517; // PRODUCTION-201611291003-338511768
        public const ushort ConvertedForwardToRoomComposer = 1331; // PRODUCTION-201611291003-338511768
        public const ushort FavoriteRoomChangedComposer = 2524; // PRODUCTION-201611291003-338511768
        public const ushort AlertPurchaseUnavailableComposer = 3770; // PRODUCTION-201611291003-338511768
        public const ushort PetBreedingStartFailedComposer = 2621; // PRODUCTION-201611291003-338511768
        public const ushort DailyQuestComposer = 1878; // PRODUCTION-201611291003-338511768
        public const ushort HotelViewHideCommunityVoteButtonComposer = 1435; // PRODUCTION-201611291003-338511768
        public const ushort CatalogSearchResultComposer = 3388; // PRODUCTION-201611291003-338511768
        public const ushort FriendFindingRoomComposer = 1210; // PRODUCTION-201611291003-338511768
        public const ushort QuestComposer = 230; // PRODUCTION-201611291003-338511768
        public const ushort ModToolSanctionDataComposer = 2782; // PRODUCTION-201611291003-338511768
        public const ushort RoomEventMessageComposer = 1840;


        public const ushort JukeBoxMySongsComposer = 2602; // PRODUCTION-201611291003-338511768
        public const ushort JukeBoxNowPlayingMessageComposer = 469; // PRODUCTION-201611291003-338511768
        public const ushort JukeBoxPlaylistFullComposer = 105; // PRODUCTION-201611291003-338511768
        public const ushort JukeBoxPlayListUpdatedComposer = 1748; // PRODUCTION-201611291003-338511768
        public const ushort JukeBoxPlayListAddSongComposer = 1140; // PRODUCTION-201611291003-338511768
        public const ushort JukeBoxPlayListComposer = 34; // PRODUCTION-201611291003-338511768
        public const ushort JukeBoxTrackDataComposer = 3365; // PRODUCTION-201611291003-338511768
        public const ushort JukeBoxTrackCodeComposer = 1381; // PRODUCTION-201611291003-338511768


        public const ushort CraftableProductsComposer = 1000; // PRODUCTION-201611291003-338511768
        public const ushort CraftingRecipeComposer = 2774; // PRODUCTION-201611291003-338511768
        public const ushort CraftingResultComposer = 618; // PRODUCTION-201611291003-338511768
        public const ushort CraftingComposerFour = 2124; // PRODUCTION-201611291003-338511768

        public const ushort UnknownComposer_100 = 1553; // PRODUCTION-201611291003-338511768 //PetBReedingResult
        public const ushort ConnectionErrorComposer = 1004; // PRODUCTION-201611291003-338511768
        public const ushort BotForceOpenContextMenuComposer = 296; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_1111 = 1551; // PRODUCTION-201611291003-338511768
        public const ushort Game2WeeklyLeaderboardComposer = 2196; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_1165 = 904; // PRODUCTION-201611291003-338511768
        public const ushort EffectsListAddComposer = 2867; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_1188 = 1437; // PRODUCTION-201611291003-338511768
        public const ushort SubmitCompetitionRoomComposer = 3841; // PRODUCTION-201611291003-338511768
        public const ushort GameAchievementsListComposer = 2265; // PRODUCTION-201611291003-338511768
        public const ushort OtherTradingDisabledComposer = 1254; // PRODUCTION-201611291003-338511768
        public const ushort BaseJumpUnloadGameComposer = 1715; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_137 = 2897; // PRODUCTION-201611291003-338511768
        public const ushort GameCenterAccountInfoComposer = 2893; // PRODUCTION-201611291003-338511768
        public const ushort UnknowComposer_1390 = 2270; // PRODUCTION-201611291003-338511768
        public const ushort BaseJumpLoadGameComposer = 3654; // PRODUCTION-201611291003-338511768
        public const ushort UnknowComposer_1427 = 3319; // PRODUCTION-201611291003-338511768
        public const ushort AdventCalendarDataComposer = 2531; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_152 = 3954; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_1577 = 2641; // PRODUCTION-201611291003-338511768
        public const ushort NewYearResolutionCompletedComposer = 740; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_1741 = 2246; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_1744 = 2873; // PRODUCTION-201611291003-338511768
        public const ushort AdventCalendarProductComposer = 2551; // PRODUCTION-201611291003-338511768
        public const ushort ModToolSanctionInfoComposer = 2221; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_1965 = 3292; // PRODUCTION-201611291003-338511768
        public const ushort GuideSessionPartnerIsPlayingComposer = 448; // PRODUCTION-201611291003-338511768
        public const ushort BaseJumpLeaveQueueComposer = 1477; // PRODUCTION-201611291003-338511768
        public const ushort Game2WeeklySmallLeaderboardComposer = 3512; // PRODUCTION-201611291003-338511768
        public const ushort GameCenterGameListComposer = 222; // PRODUCTION-201611291003-338511768
        public const ushort RoomUsersGuildBadgesComposer = 2402; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_2563 = 1774; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_2601 = 1663; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_2621 = 1927; // PRODUCTION-201611291003-338511768
        public const ushort UnknownComposer_2698 = 563; // PRODUCTION-201611291003-338511768
                                                            //    2699;
                                                            //    2748;
                                                            //    2773;
                                                            //    2964;
                                                            //    3020;
                                                            //    3024;
                                                            //    3046;
                                                            //    3124;
                                                            //    3179;
                                                            //    3189;
                                                            //    328;
                                                            //    3291;
                                                            //    3334;
        public const ushort HabboWayQuizComposer1 = 3379;
        //    3391;
        //    3427;
        //    347;
        //    3509;
        //    3519;
        //    3581;
        //    3684;
        public const ushort YouTradingDisabledComposer = 3058; // PRODUCTION-201611291003-338511768
                                                                   //    3707;
                                                                   //    3745;
                                                                   //    3759;
                                                                   //    3782;
        public const ushort RoomFloorThicknessUpdatedComposer = 3786;
        //    3822;
        public const ushort CameraPurchaseSuccesfullComposer = 2783; // PRODUCTION-201611291003-338511768
        public const ushort CameraCompetitionStatusComposer = 133; // PRODUCTION-201611291003-338511768
                                                                       //    3986;
                                                                       //    467;
                                                                       //    549;
        public const ushort CameraURLComposer = 3696; // PRODUCTION-201611291003-338511768
                                                          //    608;
                                                          //    624;
                                                          //    675;
        public const ushort HotelViewCatalogPageExpiringComposer = 690;
        //    749;
        //    812;
        //    843;
        //    947;
        //    982;


        public const ushort SimplePollAnswerComposer = 2589;

        public const ushort SomeConnectionComposer = 3928;
        public const ushort TradingWaitingConfirmComposer = 2720;
        public const ushort BaseJumpJoinQueueComposer = 2260;
        public const ushort ClubCenterDataComposer = 3277;

        public const ushort SimplePollAnswersComposer = 1066;
        public const ushort UnknownFurniModelComposer = 1501;
        public const ushort UnknownAdManagerComposer = 1808;
        public const ushort WiredOpenComposer = 1830;
        public const ushort UnknownCatalogPageOfferComposer = 1889;
        public const ushort NuxAlertComposer = 2023;
        public const ushort HotelViewExpiringCatalogPageCommposer = 2515;
        public const ushort UnknownHabboWayQuizComposer = 2772;
        public const ushort PetLevelUpdatedComposer = 2824;
        public const ushort QuestExpiredComposer = 3027;
        public const ushort UnknownTradeComposer = 3128;
        public const ushort UnknownMessengerErrorComposer = 3359;
        public const ushort UnknownComposer8 = 3441;
        public const ushort RemoveRoomEventComposer = 3479;
        public const ushort UnknownCompetitionComposer = 3506;
        public const ushort UnknownRoomViewerComposer = 3523;
        public const ushort ErrorLoginComposer = 4000;
        public const ushort HotelViewNextLTDAvailableComposer = 44;
        public const ushort HotelViewSecondsUntilComposer = 3926;
        public const ushort UnknownRoomDesktopComposer = 69;
        public const ushort UnknownGuildComposer3 = 876;

        public const ushort GameCenterGameComposer = 3805;


        public const ushort SnowStormGameStartedComposer = 5000;
        public const ushort SnowStormQuePositionComposer = 5001;
        public const ushort SnowStormStartBlockTickerComposer = 5002;
        public const ushort SnowStormStartLobbyCounterComposer = 5003;
        public const ushort SnowStormUnusedAlertGenericComposer = 5004;
        public const ushort SnowStormLongDataComposer = 5005;
        public const ushort SnowStormGameEndedComposer = 5006;
        public const ushort SnowStormQuePlayerAddedComposer = 5008;
        public const ushort SnowStormPlayAgainComposer = 5009;
        public const ushort SnowStormGamesLeftComposer = 5010;
        public const ushort SnowStormQuePlayerRemovedComposer = 5011;
        public const ushort SnowStormGamesInformationComposer = 5012;
        public const ushort SnowStormLongData2Composer = 5013;
        public const ushort UNUSED_SNOWSTORM_5014 = 5014;
        public const ushort SnowStormGameStatusComposer = 5015;
        public const ushort SnowStormFullGameStatusComposer = 5016;
        public const ushort SnowStormOnStageStartComposer = 5017;
        public const ushort SnowStormIntializeGameArenaViewComposer = 5018;
        public const ushort SnowStormRejoinPreviousRoomComposer = 5019;
        public const ushort UNKNOWN_SNOWSTORM_5020 = 5020;
        public const ushort SnowStormLevelDataComposer = 5021;
        public const ushort SnowStormOnGameEndingComposer = 5022;
        public const ushort SnowStormUserChatMessageComposer = 5023;
        public const ushort SnowStormOnStageRunningComposer = 5024;
        public const ushort SnowStormOnStageEndingComposer = 5025;
        public const ushort SnowStormIntializedPlayersComposer = 5026;
        public const ushort SnowStormOnPlayerExitedArenaComposer = 5027;
        public const ushort SnowStormGenericErrorComposer = 5028;
        public const ushort SnowStormUserRematchedComposer = 5029;

    }
}
