using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Outgoing
{
    public static class OutgoingPacketsHeader
    {
        public static const ushort PetStatusUpdateComposer = 1907;//error 404

        public static const ushort CfhTopicsMessageComposer = 325;
        public static const ushort FavoriteRoomsCountComposer = 151;
        public static const ushort UserCurrencyComposer = 2018;
        public static const ushort RedeemVoucherOKComposer = 3336;
        public static const ushort RoomUserShoutComposer = 1036;
        public static const ushort RoomUserStatusComposer = 1640;
        public static const ushort RoomUserDataComposer = 3920;
        public static const ushort RoomAddRightsListComposer = 2088;
        public static const ushort RoomRemoveRightsListComposer = 1327;
        public static const ushort RoomRightsListComposer = 1284;
        public static const ushort RoomUserHandItemComposer = 1474;
        public static const ushort RoomUsersComposer = 374;
        public static const ushort FriendRequestComposer = 2219;
        public static const ushort GuildBoughtComposer = 2808;
        public static const ushort AddUserBadgeComposer = 2493;
        public static const ushort RecyclerCompleteComposer = 468;
        public static const ushort GuildBuyRoomsComposer = 2159;
        public static const ushort FriendsComposer = 3130;
        public static const ushort StalkErrorComposer = 3048;
        public static const ushort TradeCloseWindowComposer = 1001;
        public static const ushort RemoveFloorItemComposer = 2703;
        public static const ushort InventoryPetsComposer = 3522;
        public static const ushort UserCreditsComposer = 3475;
        public static const ushort WiredTriggerDataComposer = 383;
        public static const ushort TradeStoppedComposer = 1373;
        public static const ushort ModToolUserChatlogComposer = 3377;
        public static const ushort GuildInfoComposer = 1702;
        public static const ushort UserPermissionsComposer = 411;
        public static const ushort PetNameErrorComposer = 1503;
        public static const ushort TradeStartFailComposer = 217;
        public static const ushort AddHabboItemComposer = 2103;
        public static const ushort InventoryBotsComposer = 3086;
        public static const ushort CanCreateRoomComposer = 378;
        public static const ushort MarketplaceBuyErrorComposer = 2032;
        public static const ushort BonusRareComposer = 1533;
        public static const ushort HotelViewComposer = 122;
        public static const ushort UpdateFriendComposer = 2800;
        public static const ushort FloorItemUpdateComposer = 3776;
        public static const ushort RoomAccessDeniedComposer = 878;
        public static const ushort GuildFurniWidgetComposer = 3293;
        public static const ushort GiftConfigurationComposer = 2234;
        public static const ushort UserClubComposer = 954;
        public static const ushort InventoryBadgesComposer = 717;
        public static const ushort RoomUserTypingComposer = 1717;
        public static const ushort GuildJoinErrorComposer = 762;
        public static const ushort RoomCategoriesComposer = 1562;
        public static const ushort InventoryAchievementsComposer = 2501;
        public static const ushort MarketplaceItemInfoComposer = 725;
        public static const ushort RoomRelativeMapComposer = 2753;
        public static const ushort ModToolComposerTwo = 2335;
        public static const ushort ModToolComposerOne = 3192;
        public static const ushort RoomRightsComposer = 780;
        public static const ushort ObjectOnRollerComposer = 3207;
        public static const ushort PollStartComposer = 3785;
        public static const ushort GuildRefreshMembersListComposer = 2445;
        public static const ushort UserPerksComposer = 2586;
        public static const ushort UserCitizinShipComposer = 1203;
        public static const ushort PublicRoomsComposer = -1;//error 404
        public static const ushort MarketplaceOffersComposer = 680;
        public static const ushort ModToolComposer = 2696;
        public static const ushort UserBadgesComposer = 1087;
        public static const ushort GuildManageComposer = 3965;
        public static const ushort RemoveFriendComposer = -1;//error 404
        public static const ushort InitDiffieHandshakeComposer = 1347;
        public static const ushort CompleteDiffieHandshakeComposer = 3885;
        public static const ushort UserDataComposer = 2725;
        public static const ushort UserSearchResultComposer = 973;
        public static const ushort ModToolUserRoomVisitsComposer = 1752;
        public static const ushort RoomUserRespectComposer = 2815;
        public static const ushort RoomChatSettingsComposer = 1191;
        public static const ushort RemoveHabboItemComposer = 159;
        public static const ushort RoomUserRemoveComposer = 2661;
        public static const ushort RoomHeightMapComposer = 1301;
        public static const ushort RoomPetHorseFigureComposer = 1924;
        public static const ushort PetErrorComposer = 2913;
        public static const ushort TradeUpdateComposer = 2024;
        public static const ushort PrivateRoomsComposer = 52;
        public static const ushort RoomModelComposer = 2031;
        public static const ushort RoomScoreComposer = 482;
        public static const ushort DoorbellAddUserComposer = 2309;
        public static const ushort SecureLoginOKComposer = 2491;
        public static const ushort SessionRightsComposer = 2033;
        public static const ushort GuildMemberUpdateComposer = 265;
        public static const ushort RoomFloorItemsComposer = 1778;
        public static const ushort InventoryItemsComposer = 994;
        public static const ushort RoomUserTalkComposer = 1446;
        public static const ushort TradeStartComposer = 2505;
        public static const ushort InventoryItemUpdateComposer = 104;
        public static const ushort ModToolIssueUpdateComposer = 3150;
        public static const ushort MeMenuSettingsComposer = 513;
        public static const ushort ModToolRoomInfoComposer = 1333;
        public static const ushort GuildListComposer = 420;
        public static const ushort RecyclerLogicComposer = 3164;
        public static const ushort UserHomeRoomComposer = 2875;
        public static const ushort RoomUserDanceComposer = 2233;
        public static const ushort RoomSettingsUpdatedComposer = 3297;
        public static const ushort AlertPurchaseFailedComposer = 1404;
        public static const ushort RoomDataComposer = 687;
        public static const ushort TagsComposer = 2012;
        public static const ushort InventoryRefreshComposer = 3151; // PRODUCTION-201611291003-338511768
        public static const ushort RemovePetComposer = 3253; // PRODUCTION-201611291003-338511768
        public static const ushort RemoveWallItemComposer = 3208; // PRODUCTION-201611291003-338511768
        public static const ushort TradeCompleteComposer = 2369; // PRODUCTION-201611291003-338511768
        public static const ushort NewsWidgetsComposer = 286; // PRODUCTION-201611291003-338511768
        public static const ushort WiredEffectDataComposer = 1434; // PRODUCTION-201611291003-338511768
        public static const ushort BubbleAlertComposer = 1992; // PRODUCTION-201611291003-338511768
        public static const ushort ReloadRecyclerComposer = 3433; // PRODUCTION-201611291003-338511768
        public static const ushort MoodLightDataComposer = 2710; // PRODUCTION-201611291003-338511768
        public static const ushort WiredRewardAlertComposer = 178; // PRODUCTION-201611291003-338511768
        public static const ushort CatalogPageComposer = 804; // PRODUCTION-201611291003-338511768
        public static const ushort CatalogModeComposer = 3828; // PRODUCTION-201611291003-338511768
        public static const ushort ChangeNameUpdateComposer = 118; // PRODUCTION-201611291003-338511768
        public static const ushort AddFloorItemComposer = 1534; // PRODUCTION-201611291003-338511768
        public static const ushort DebugConsoleComposer = 3284; // PRODUCTION-201611291003-338511768
        public static const ushort HallOfFameComposer = 3005; // PRODUCTION-201611291003-338511768
        public static const ushort WiredSavedComposer = 1155; // PRODUCTION-201611291003-338511768
        public static const ushort RoomPaintComposer = 2454; // PRODUCTION-201611291003-338511768
        public static const ushort MarketplaceConfigComposer = 1823; // PRODUCTION-201611291003-338511768
        public static const ushort AddBotComposer = 1352; // PRODUCTION-201611291003-338511768
        public static const ushort FriendRequestErrorComposer = 892; // PRODUCTION-201611291003-338511768
        public static const ushort GuildMembersComposer = 1200; // PRODUCTION-201611291003-338511768
        public static const ushort RoomOpenComposer = 758; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolRoomChatlogComposer = 3434; // PRODUCTION-201611291003-338511768
        public static const ushort DiscountComposer = 2347; // PRODUCTION-201611291003-338511768
        public static const ushort MarketplaceCancelSaleComposer = 3264; // PRODUCTION-201611291003-338511768
        public static const ushort RoomPetRespectComposer = 2788; // PRODUCTION-201611291003-338511768
        public static const ushort RoomSettingsComposer = 1498; // PRODUCTION-201611291003-338511768
        public static const ushort TalentTrackComposer = 3406; // PRODUCTION-201611291003-338511768
        public static const ushort CatalogPagesListComposer = 1032; // PRODUCTION-201611291003-338511768
        public static const ushort AlertLimitedSoldOutComposer = 377; // PRODUCTION-201611291003-338511768
        public static const ushort CatalogUpdatedComposer = 1866; // PRODUCTION-201611291003-338511768
        public static const ushort PurchaseOKComposer = 869; // PRODUCTION-201611291003-338511768
        public static const ushort WallItemUpdateComposer = 2009; // PRODUCTION-201611291003-338511768
        public static const ushort TradeAcceptedComposer = 2568; // PRODUCTION-201611291003-338511768
        public static const ushort AddWallItemComposer = 2187; // PRODUCTION-201611291003-338511768
        public static const ushort RoomEntryInfoComposer = -1; // PRODUCTION-201611291003-338511768
        public static const ushort HotelViewDataComposer = 1745; // PRODUCTION-201611291003-338511768
        public static const ushort PresentItemOpenedComposer = 56; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserRemoveRightsComposer = 84; // PRODUCTION-201611291003-338511768
        public static const ushort UserBCLimitsComposer = -1; // PRODUCTION-201611291003-338511768
        public static const ushort PetTrainingPanelComposer = 1164; // PRODUCTION-201611291003-338511768
        public static const ushort RoomPaneComposer = 749; // PRODUCTION-201611291003-338511768
        public static const ushort RedeemVoucherErrorComposer = 714; // PRODUCTION-201611291003-338511768
        public static const ushort RoomCreatedComposer = 1304; // PRODUCTION-201611291003-338511768
        public static const ushort GenericAlertComposer = 3801; // PRODUCTION-201611291003-338511768
        public static const ushort GroupPartsComposer = 2238; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolIssueInfoComposer = 3609; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserWhisperComposer = 2704; // PRODUCTION-201611291003-338511768
        public static const ushort BotErrorComposer = 639; // PRODUCTION-201611291003-338511768
        public static const ushort FreezeLivesComposer = 2324; // PRODUCTION-201611291003-338511768
        public static const ushort LoadFriendRequestsComposer = 280; // PRODUCTION-201611291003-338511768
        public static const ushort MarketplaceSellItemComposer = 54; // PRODUCTION-201611291003-338511768
        public static const ushort ClubDataComposer = 2405; // PRODUCTION-201611291003-338511768
        public static const ushort ProfileFriendsComposer = 2016; // PRODUCTION-201611291003-338511768
        public static const ushort MarketplaceOwnItemsComposer = 3884; // PRODUCTION-201611291003-338511768
        public static const ushort RoomOwnerComposer = 339; // PRODUCTION-201611291003-338511768
        public static const ushort WiredConditionDataComposer = 1108; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolUserInfoComposer = 2866; // PRODUCTION-201611291003-338511768
        public static const ushort UserWardrobeComposer = 3315; // PRODUCTION-201611291003-338511768
        public static const ushort RoomPetExperienceComposer = 2156; // PRODUCTION-201611291003-338511768
        public static const ushort FriendChatMessageComposer = 1587; // PRODUCTION-201611291003-338511768
        public static const ushort PetInformationComposer = 2901; // PRODUCTION-201611291003-338511768
        public static const ushort RoomThicknessComposer = 3547; // PRODUCTION-201611291003-338511768
        public static const ushort AddPetComposer = 2101; // PRODUCTION-201611291003-338511768
        public static const ushort UpdateStackHeightComposer = 558; // PRODUCTION-201611291003-338511768
        public static const ushort RemoveBotComposer = 233; // PRODUCTION-201611291003-338511768
        public static const ushort RoomEnterErrorComposer = 899; // PRODUCTION-201611291003-338511768
        public static const ushort PollQuestionsComposer = 2997; // PRODUCTION-201611291003-338511768
        public static const ushort GenericErrorMessages = 1600; // PRODUCTION-201611291003-338511768
        public static const ushort RoomWallItemsComposer = 1369; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserEffectComposer = 1167; // PRODUCTION-201611291003-338511768
        public static const ushort PetBreedsComposer = 3331; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolIssueChatlogComposer = 607; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserActionComposer = 1631; // PRODUCTION-201611291003-338511768
        public static const ushort BotSettingsComposer = 1618; // PRODUCTION-201611291003-338511768
        public static const ushort UserProfileComposer = 3898; // PRODUCTION-201611291003-338511768
        public static const ushort MinimailCountComposer = 2803; // PRODUCTION-201611291003-338511768
        public static const ushort UserAchievementScoreComposer = 1968; // PRODUCTION-201611291003-338511768
        public static const ushort PetLevelUpComposer = 859; // PRODUCTION-201611291003-338511768
        public static const ushort UserPointsComposer = 2275; // PRODUCTION-201611291003-338511768
        public static const ushort ReportRoomFormComposer = 1121; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolIssueHandledComposer = 934; // PRODUCTION-201611291003-338511768
        public static const ushort FloodCounterComposer = 566; // PRODUCTION-201611291003-338511768
        public static const ushort UpdateFailedComposer = 156; // PRODUCTION-201611291003-338511768
        public static const ushort FloorPlanEditorDoorSettingsComposer = 1664; // PRODUCTION-201611291003-338511768
        public static const ushort FloorPlanEditorBlockedTilesComposer = 3990; // PRODUCTION-201611291003-338511768
        public static const ushort BuildersClubExpiredComposer = 1452; // PRODUCTION-201611291003-338511768
        public static const ushort RoomSettingsSavedComposer = 948; // PRODUCTION-201611291003-338511768
        public static const ushort MessengerInitComposer = 1605; // PRODUCTION-201611291003-338511768
        public static const ushort UserClothesComposer = 1450; // PRODUCTION-201611291003-338511768
        public static const ushort UserEffectsListComposer = 340; // PRODUCTION-201611291003-338511768
        public static const ushort NewUserIdentityComposer = 3738; // PRODUCTION-201611291003-338511768
        public static const ushort NewNavigatorEventCategoriesComposer = 3244; // PRODUCTION-201611291003-338511768
        public static const ushort NewNavigatorCollapsedCategoriesComposer = 1543; // PRODUCTION-201611291003-338511768
        public static const ushort NewNavigatorLiftedRoomsComposer = 3104; // PRODUCTION-201611291003-338511768
        public static const ushort NewNavigatorSavedSearchesComposer = 3984; // PRODUCTION-201611291003-338511768
        public static const ushort PostItDataComposer = 2202; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolReportReceivedAlertComposer = 3635; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolIssueResponseAlertComposer = 3796; // PRODUCTION-201611291003-338511768
        public static const ushort AchievementListComposer = 305; // PRODUCTION-201611291003-338511768
        public static const ushort AchievementProgressComposer = 2107; // PRODUCTION-201611291003-338511768
        public static const ushort AchievementUnlockedComposer = 806; // PRODUCTION-201611291003-338511768
        public static const ushort ClubGiftsComposer = 619; // PRODUCTION-201611291003-338511768
        public static const ushort MachineIDComposer = 1488; // PRODUCTION-201611291003-338511768
        public static const ushort PongComposer = 10; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolIssueHandlerDimensionsComposer = 1576; // PRODUCTION-201611291003-338511768

        //Uknown but work
        public static const ushort IsFirstLoginOfDayComposer = 793; // PRODUCTION-201611291003-338511768 //Quest Engine
        public static const ushort UnknownComposer5 = 2833; // PRODUCTION-201611291003-338511768 //Mysterbox
        public static const ushort IgnoredUsersComposer = 126; // PRODUCTION-201611291003-338511768
        public static const ushort NewNavigatorMetaDataComposer = 3052; // PRODUCTION-201611291003-338511768
        public static const ushort NewNavigatorSearchResultsComposer = 2690; // PRODUCTION-201611291003-338511768
        public static const ushort MysticBoxStartOpenComposer = 3201; // PRODUCTION-201611291003-338511768
        public static const ushort MysticBoxCloseComposer = 596; // PRODUCTION-201611291003-338511768
        public static const ushort MysticBoxPrizeComposer = 3712; // PRODUCTION-201611291003-338511768
        public static const ushort RentableSpaceInfoComposer = 3559; // PRODUCTION-201611291003-338511768
        public static const ushort RentableSpaceUnknownComposer = 2046; // PRODUCTION-201611291003-338511768
        public static const ushort RentableSpaceUnknown2Composer = 1868; // PRODUCTION-201611291003-338511768
        public static const ushort GuildConfirmRemoveMemberComposer = 1876; // PRODUCTION-201611291003-338511768

        public static const ushort HotelViewBadgeButtonConfigComposer = 2998; // PRODUCTION-201611291003-338511768
        public static const ushort EpicPopupFrameComposer = 3945; // PRODUCTION-201611291003-338511768
        public static const ushort BaseJumpLoadGameURLComposer = 2624; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserTagsComposer = 1255; // PRODUCTION-201611291003-338511768
        public static const ushort RoomInviteErrorComposer = 462; // PRODUCTION-201611291003-338511768
        public static const ushort PostItStickyPoleOpenComposer = 2366; // PRODUCTION-201611291003-338511768
        public static const ushort NewYearResolutionProgressComposer = 3370; // PRODUCTION-201611291003-338511768
        public static const ushort ClubGiftReceivedComposer = 659; // PRODUCTION-201611291003-338511768
        public static const ushort ItemStateComposer = 2376; // PRODUCTION-201611291003-338511768
        public static const ushort ItemExtraDataComposer = 2547; // PRODUCTION-201611291003-338511768
        public static const ushort PostUpdateMessageComposer = 324; // PRODUCTION-201611291003-338511768
                                                                 //NotSure Needs Testing
        public static const ushort QuestionInfoComposer = -1; // PRODUCTION-201611291003-338511768
        public static const ushort TalentTrackEmailVerifiedComposer = 612; // PRODUCTION-201611291003-338511768
        public static const ushort TalentTrackEmailFailedComposer = 1815; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownAvatarEditorComposer = 3473; // PRODUCTION-201611291003-338511768

        public static const ushort GuildMembershipRequestedComposer = 1180; // PRODUCTION-201611291003-338511768

        public static const ushort GuildForumsUnreadMessagesCountComposer = 2379; // PRODUCTION-201611291003-338511768
        public static const ushort GuildForumThreadMessagesComposer = 1862; // PRODUCTION-201611291003-338511768
        public static const ushort GuildForumAddCommentComposer = 2049; // PRODUCTION-201611291003-338511768
        public static const ushort GuildForumDataComposer = 3011; // PRODUCTION-201611291003-338511768
        public static const ushort GuildForumCommentsComposer = 509; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownGuildForumComposer6 = -1; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownGuildForumComposer7 = -1; // PRODUCTION-201611291003-338511768
        public static const ushort GuildForumThreadsComposer = 1073; // PRODUCTION-201611291003-338511768
        public static const ushort GuildForumListComposer = 3001; // PRODUCTION-201611291003-338511768
        public static const ushort ThreadUpdateMessageComposer = 2528;
        public static const ushort GuideSessionAttachedComposer = 1591; // PRODUCTION-201611291003-338511768
        public static const ushort GuideSessionDetachedComposer = 138; // PRODUCTION-201611291003-338511768
        public static const ushort GuideSessionStartedComposer = 3209; // PRODUCTION-201611291003-338511768
        public static const ushort GuideSessionEndedComposer = 1456; // PRODUCTION-201611291003-338511768
        public static const ushort GuideSessionErrorComposer = 673; // PRODUCTION-201611291003-338511768
        public static const ushort GuideSessionMessageComposer = 841; // PRODUCTION-201611291003-338511768
        public static const ushort GuideSessionRequesterRoomComposer = 1847; // PRODUCTION-201611291003-338511768
        public static const ushort GuideSessionInvitedToGuideRoomComposer = 219; // PRODUCTION-201611291003-338511768
        public static const ushort GuideSessionPartnerIsTypingComposer = 1016; // PRODUCTION-201611291003-338511768

        public static const ushort GuideToolsComposer = 1548; // PRODUCTION-201611291003-338511768
        public static const ushort GuardianNewReportReceivedComposer = 735; // PRODUCTION-201611291003-338511768
        public static const ushort GuardianVotingRequestedComposer = 143; // PRODUCTION-201611291003-338511768
        public static const ushort GuardianVotingVotesComposer = 1829; // PRODUCTION-201611291003-338511768
        public static const ushort GuardianVotingResultComposer = 3276; // PRODUCTION-201611291003-338511768
        public static const ushort GuardianVotingTimeEnded = 30; // PRODUCTION-201611291003-338511768

        public static const ushort RoomMutedComposer = 2533; // PRODUCTION-201611291003-338511768

        public static const ushort HideDoorbellComposer = 3783; // PRODUCTION-201611291003-338511768
        public static const ushort RoomQueueStatusMessage = 2208; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUnknown3Composer = 1033; // PRODUCTION-201611291003-338511768

        public static const ushort EffectsListRemoveComposer = 2228; // PRODUCTION-201611291003-338511768

        public static const ushort OldPublicRoomsComposer = 2726; // PRODUCTION-201611291003-338511768
        public static const ushort ItemStateComposer2 = 3431; // PRODUCTION-201611291003-338511768

        public static const ushort HotelWillCloseInMinutesComposer = 1050; // PRODUCTION-201611291003-338511768
        public static const ushort HotelWillCloseInMinutesAndBackInComposer = 1350; // PRODUCTION-201611291003-338511768
        public static const ushort HotelClosesAndWillOpenAtComposer = 2771; // PRODUCTION-201611291003-338511768
        public static const ushort HotelClosedAndOpensComposer = 3728; // PRODUCTION-201611291003-338511768
        public static const ushort StaffAlertAndOpenHabboWayComposer = 1683; // PRODUCTION-201611291003-338511768
        public static const ushort StaffAlertWithLinkComposer = 2030; // PRODUCTION-201611291003-338511768
        public static const ushort StaffAlertWIthLinkAndOpenHabboWayComposer = 1890; // PRODUCTION-201611291003-338511768

        public static const ushort RoomMessagesPostedCountComposer = 1634; // PRODUCTION-201611291003-338511768
        public static const ushort CantScratchPetNotOldEnoughComposer = 1130; // PRODUCTION-201611291003-338511768
        public static const ushort PetBoughtNotificationComposer = 1111; // PRODUCTION-201611291003-338511768
        public static const ushort MessagesForYouComposer = 2035; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownStatusComposer = 1243; // PRODUCTION-201611291003-338511768
        public static const ushort CloseWebPageComposer = 426; // PRODUCTION-201611291003-338511768
        public static const ushort PickMonthlyClubGiftNotificationComposer = 2188; // PRODUCTION-201611291003-338511768
        public static const ushort RemoveGuildFromRoomComposer = 3129; // PRODUCTION-201611291003-338511768
        public static const ushort RoomBannedUsersComposer = 1869; // PRODUCTION-201611291003-338511768
        public static const ushort OpenRoomCreationWindowComposer = 2064; // PRODUCTION-201611291003-338511768
        public static const ushort ItemsDataUpdateComposer = 1453; // PRODUCTION-201611291003-338511768
        public static const ushort WelcomeGiftComposer = 2707; // PRODUCTION-201611291003-338511768
        public static const ushort SimplePollStartComposer = 2665; // PRODUCTION-201611291003-338511768
        public static const ushort RoomNoRightsComposer = 2392; // PRODUCTION-201611291003-338511768
        public static const ushort GuildEditFailComposer = 3988; // PRODUCTION-201611291003-338511768
        public static const ushort MinimailNewMessageComposer = 1911; // PRODUCTION-201611291003-338511768
        public static const ushort RoomFilterWordsComposer = 2937; // PRODUCTION-201611291003-338511768
        public static const ushort VerifyMobileNumberComposer = 3639; // PRODUCTION-201611291003-338511768
        public static const ushort NewUserGiftComposer = 3575; // PRODUCTION-201611291003-338511768
        public static const ushort UpdateUserLookComposer = 2429; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserIgnoredComposer = 207; // PRODUCTION-201611291003-338511768
        public static const ushort PetBreedingFailedComposer = 1625; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserNameChangedComposer = 2182; // PRODUCTION-201611291003-338511768
        public static const ushort LoveLockFurniStartComposer = 3753; // PRODUCTION-201611291003-338511768
        public static const ushort LoveLockFurniFriendConfirmedComposer = 382; // PRODUCTION-201611291003-338511768
        public static const ushort LoveLockFurniFinishedComposer = 770; // PRODUCTION-201611291003-338511768
        public static const ushort PetPackageNameValidationComposer = 546; // PRODUCTION-201611291003-338511768
        public static const ushort GameCenterFeaturedPlayersComposer = 3097; // PRODUCTION-201611291003-338511768
        public static const ushort HabboMallComposer = 1237; // PRODUCTION-201611291003-338511768
        public static const ushort TargetedOfferComposer = 119; // PRODUCTION-201611291003-338511768
        public static const ushort LeprechaunStarterBundleComposer = 2380; // PRODUCTION-201611291003-338511768
        public static const ushort VerifyMobilePhoneWindowComposer = 2890; // PRODUCTION-201611291003-338511768
        public static const ushort VerifyMobilePhoneCodeWindowComposer = 800; // PRODUCTION-201611291003-338511768
        public static const ushort VerifyMobilePhoneDoneComposer = 91; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserReceivedHandItemComposer = 354; // PRODUCTION-201611291003-338511768
        public static const ushort MutedWhisperComposer = 826; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownHintComposer = 1787; // PRODUCTION-201611291003-338511768
        public static const ushort BullyReportClosedComposer = 2674; // PRODUCTION-201611291003-338511768
        public static const ushort PromoteOwnRoomsListComposer = 2468; // PRODUCTION-201611291003-338511768
        public static const ushort NotEnoughPointsTypeComposer = 3914; // PRODUCTION-201611291003-338511768
        public static const ushort WatchAndEarnRewardComposer = 2125; // PRODUCTION-201611291003-338511768
        public static const ushort NewYearResolutionComposer = 66; // PRODUCTION-201611291003-338511768
        public static const ushort WelcomeGiftErrorComposer = 2293; // PRODUCTION-201611291003-338511768
        public static const ushort RentableItemBuyOutPriceComposer = 35; // PRODUCTION-201611291003-338511768
        public static const ushort VipTutorialsStartComposer = 2278; // PRODUCTION-201611291003-338511768
        public static const ushort NewNavigatorCategoryUserCountComposer = 1455; // PRODUCTION-201611291003-338511768
        public static const ushort CameraRoomThumbnailSavedComposer = 3595; // PRODUCTION-201611291003-338511768
        public static const ushort RoomEditSettingsErrorComposer = 1555; // PRODUCTION-201611291003-338511768
        public static const ushort GuildAcceptMemberErrorComposer = 818; // PRODUCTION-201611291003-338511768
        public static const ushort MostUselessErrorAlertComposer = 662; // PRODUCTION-201611291003-338511768
        public static const ushort AchievementsConfigurationComposer = 1689; // PRODUCTION-201611291003-338511768
        public static const ushort PetBreedingResultComposer = 634; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserQuestionAnsweredComposer = -1; // PRODUCTION-201611291003-338511768
        public static const ushort PetBreedingStartComposer = 1746; // PRODUCTION-201611291003-338511768
        public static const ushort CustomNotificationComposer = 909; // PRODUCTION-201611291003-338511768
        public static const ushort UpdateStackHeightTileHeightComposer = 2816; // PRODUCTION-201611291003-338511768
        public static const ushort HotelViewCustomTimerComposer = -1; // PRODUCTION-201611291003-338511768
        public static const ushort MarketplaceItemPostedComposer = 1359; // PRODUCTION-201611291003-338511768
        public static const ushort HabboWayQuizComposer2 = 2927; // PRODUCTION-201611291003-338511768
        public static const ushort GuildFavoriteRoomUserUpdateComposer = 3403; // PRODUCTION-201611291003-338511768
        public static const ushort RoomAdErrorComposer = 1759; // PRODUCTION-201611291003-338511768
        public static const ushort NewNavigatorSettingsComposer = 518; // PRODUCTION-201611291003-338511768
        public static const ushort CameraPublishWaitMessageComposer = 2057; // PRODUCTION-201611291003-338511768
        public static const ushort RoomInviteComposer = 3870; // PRODUCTION-201611291003-338511768
        public static const ushort BullyReportRequestComposer = 3463; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownHelperComposer = 77; // PRODUCTION-201611291003-338511768
        public static const ushort HelperRequestDisabledComposer = 1651; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUnitIdleComposer = 1797; // PRODUCTION-201611291003-338511768
        public static const ushort QuestCompletedComposer = 949; // PRODUCTION-201611291003-338511768
        public static const ushort UnkownPetPackageComposer = 1723; // PRODUCTION-201611291003-338511768
        public static const ushort ForwardToRoomComposer = 160; // PRODUCTION-201611291003-338511768
        public static const ushort EffectsListEffectEnableComposer = 1959; // PRODUCTION-201611291003-338511768
        public static const ushort CompetitionEntrySubmitResultComposer = 1177; // PRODUCTION-201611291003-338511768
        public static const ushort ExtendClubMessageComposer = 3964; // PRODUCTION-201611291003-338511768
        public static const ushort HotelViewConcurrentUsersComposer = 2737; // PRODUCTION-201611291003-338511768
        public static const ushort InventoryAddEffectComposer = -1;//error 404
        public static const ushort TalentLevelUpdateComposer = 638; // PRODUCTION-201611291003-338511768
        public static const ushort BullyReportedMessageComposer = 3285; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownQuestComposer3 = 1122; // PRODUCTION-201611291003-338511768
        public static const ushort FriendToolbarNotificationComposer = 3082; // PRODUCTION-201611291003-338511768
        public static const ushort MessengerErrorComposer = 896; // PRODUCTION-201611291003-338511768
        public static const ushort CameraPriceComposer = 3878; // PRODUCTION-201611291003-338511768
        public static const ushort PetBreedingCompleted = 2527; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUserUnbannedComposer = 3429; // PRODUCTION-201611291003-338511768
        public static const ushort HotelViewCommunityGoalComposer = 2525; // PRODUCTION-201611291003-338511768
        public static const ushort UserClassificationComposer = 966; // PRODUCTION-201611291003-338511768
        public static const ushort CanCreateEventComposer = 2599; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownGuild2Composer = 1459; // PRODUCTION-201611291003-338511768
        public static const ushort YoutubeDisplayListComposer = 1112; // PRODUCTION-201611291003-338511768
        public static const ushort YoutubeMessageComposer2 = 1411; // PRODUCTION-201611291003-338511768
        public static const ushort YoutubeMessageComposer3 = 1554; // PRODUCTION-201611291003-338511768
        public static const ushort RoomCategoryUpdateMessageComposer = 3896; // PRODUCTION-201611291003-338511768
        public static const ushort QuestsComposer = 3625; // PRODUCTION-201611291003-338511768
        public static const ushort GiftReceiverNotFoundComposer = 1517; // PRODUCTION-201611291003-338511768
        public static const ushort ConvertedForwardToRoomComposer = 1331; // PRODUCTION-201611291003-338511768
        public static const ushort FavoriteRoomChangedComposer = 2524; // PRODUCTION-201611291003-338511768
        public static const ushort AlertPurchaseUnavailableComposer = 3770; // PRODUCTION-201611291003-338511768
        public static const ushort PetBreedingStartFailedComposer = 2621; // PRODUCTION-201611291003-338511768
        public static const ushort DailyQuestComposer = 1878; // PRODUCTION-201611291003-338511768
        public static const ushort HotelViewHideCommunityVoteButtonComposer = 1435; // PRODUCTION-201611291003-338511768
        public static const ushort CatalogSearchResultComposer = 3388; // PRODUCTION-201611291003-338511768
        public static const ushort FriendFindingRoomComposer = 1210; // PRODUCTION-201611291003-338511768
        public static const ushort QuestComposer = 230; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolSanctionDataComposer = 2782; // PRODUCTION-201611291003-338511768
        public static const ushort RoomEventMessageComposer = 1840;


        public static const ushort JukeBoxMySongsComposer = 2602; // PRODUCTION-201611291003-338511768
        public static const ushort JukeBoxNowPlayingMessageComposer = 469; // PRODUCTION-201611291003-338511768
        public static const ushort JukeBoxPlaylistFullComposer = 105; // PRODUCTION-201611291003-338511768
        public static const ushort JukeBoxPlayListUpdatedComposer = 1748; // PRODUCTION-201611291003-338511768
        public static const ushort JukeBoxPlayListAddSongComposer = 1140; // PRODUCTION-201611291003-338511768
        public static const ushort JukeBoxPlayListComposer = 34; // PRODUCTION-201611291003-338511768
        public static const ushort JukeBoxTrackDataComposer = 3365; // PRODUCTION-201611291003-338511768
        public static const ushort JukeBoxTrackCodeComposer = 1381; // PRODUCTION-201611291003-338511768


        public static const ushort CraftableProductsComposer = 1000; // PRODUCTION-201611291003-338511768
        public static const ushort CraftingRecipeComposer = 2774; // PRODUCTION-201611291003-338511768
        public static const ushort CraftingResultComposer = 618; // PRODUCTION-201611291003-338511768
        public static const ushort CraftingComposerFour = 2124; // PRODUCTION-201611291003-338511768

        public static const ushort UnknownComposer_100 = 1553; // PRODUCTION-201611291003-338511768 //PetBReedingResult
        public static const ushort ConnectionErrorComposer = 1004; // PRODUCTION-201611291003-338511768
        public static const ushort BotForceOpenContextMenuComposer = 296; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_1111 = 1551; // PRODUCTION-201611291003-338511768
        public static const ushort Game2WeeklyLeaderboardComposer = 2196; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_1165 = 904; // PRODUCTION-201611291003-338511768
        public static const ushort EffectsListAddComposer = 2867; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_1188 = 1437; // PRODUCTION-201611291003-338511768
        public static const ushort SubmitCompetitionRoomComposer = 3841; // PRODUCTION-201611291003-338511768
        public static const ushort GameAchievementsListComposer = 2265; // PRODUCTION-201611291003-338511768
        public static const ushort OtherTradingDisabledComposer = 1254; // PRODUCTION-201611291003-338511768
        public static const ushort BaseJumpUnloadGameComposer = 1715; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_137 = 2897; // PRODUCTION-201611291003-338511768
        public static const ushort GameCenterAccountInfoComposer = 2893; // PRODUCTION-201611291003-338511768
        public static const ushort UnknowComposer_1390 = 2270; // PRODUCTION-201611291003-338511768
        public static const ushort BaseJumpLoadGameComposer = 3654; // PRODUCTION-201611291003-338511768
        public static const ushort UnknowComposer_1427 = 3319; // PRODUCTION-201611291003-338511768
        public static const ushort AdventCalendarDataComposer = 2531; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_152 = 3954; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_1577 = 2641; // PRODUCTION-201611291003-338511768
        public static const ushort NewYearResolutionCompletedComposer = 740; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_1741 = 2246; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_1744 = 2873; // PRODUCTION-201611291003-338511768
        public static const ushort AdventCalendarProductComposer = 2551; // PRODUCTION-201611291003-338511768
        public static const ushort ModToolSanctionInfoComposer = 2221; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_1965 = 3292; // PRODUCTION-201611291003-338511768
        public static const ushort GuideSessionPartnerIsPlayingComposer = 448; // PRODUCTION-201611291003-338511768
        public static const ushort BaseJumpLeaveQueueComposer = 1477; // PRODUCTION-201611291003-338511768
        public static const ushort Game2WeeklySmallLeaderboardComposer = 3512; // PRODUCTION-201611291003-338511768
        public static const ushort GameCenterGameListComposer = 222; // PRODUCTION-201611291003-338511768
        public static const ushort RoomUsersGuildBadgesComposer = 2402; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_2563 = 1774; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_2601 = 1663; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_2621 = 1927; // PRODUCTION-201611291003-338511768
        public static const ushort UnknownComposer_2698 = 563; // PRODUCTION-201611291003-338511768
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
        public static const ushort HabboWayQuizComposer1 = 3379;
        //    3391;
        //    3427;
        //    347;
        //    3509;
        //    3519;
        //    3581;
        //    3684;
        public static const ushort YouTradingDisabledComposer = 3058; // PRODUCTION-201611291003-338511768
                                                                   //    3707;
                                                                   //    3745;
                                                                   //    3759;
                                                                   //    3782;
        public static const ushort RoomFloorThicknessUpdatedComposer = 3786;
        //    3822;
        public static const ushort CameraPurchaseSuccesfullComposer = 2783; // PRODUCTION-201611291003-338511768
        public static const ushort CameraCompetitionStatusComposer = 133; // PRODUCTION-201611291003-338511768
                                                                       //    3986;
                                                                       //    467;
                                                                       //    549;
        public static const ushort CameraURLComposer = 3696; // PRODUCTION-201611291003-338511768
                                                          //    608;
                                                          //    624;
                                                          //    675;
        public static const ushort HotelViewCatalogPageExpiringComposer = 690;
        //    749;
        //    812;
        //    843;
        //    947;
        //    982;


        public static const ushort SimplePollAnswerComposer = 2589;

        public static const ushort SomeConnectionComposer = 3928;
        public static const ushort TradingWaitingConfirmComposer = 2720;
        public static const ushort BaseJumpJoinQueueComposer = 2260;
        public static const ushort ClubCenterDataComposer = 3277;

        public static const ushort SimplePollAnswersComposer = 1066;
        public static const ushort UnknownFurniModelComposer = 1501;
        public static const ushort UnknownAdManagerComposer = 1808;
        public static const ushort WiredOpenComposer = 1830;
        public static const ushort UnknownCatalogPageOfferComposer = 1889;
        public static const ushort NuxAlertComposer = 2023;
        public static const ushort HotelViewExpiringCatalogPageCommposer = 2515;
        public static const ushort UnknownHabboWayQuizComposer = 2772;
        public static const ushort PetLevelUpdatedComposer = 2824;
        public static const ushort QuestExpiredComposer = 3027;
        public static const ushort UnknownTradeComposer = 3128;
        public static const ushort UnknownMessengerErrorComposer = 3359;
        public static const ushort UnknownComposer8 = 3441;
        public static const ushort RemoveRoomEventComposer = 3479;
        public static const ushort UnknownCompetitionComposer = 3506;
        public static const ushort UnknownRoomViewerComposer = 3523;
        public static const ushort ErrorLoginComposer = 4000;
        public static const ushort HotelViewNextLTDAvailableComposer = 44;
        public static const ushort HotelViewSecondsUntilComposer = 3926;
        public static const ushort UnknownRoomDesktopComposer = 69;
        public static const ushort UnknownGuildComposer3 = 876;

        public static const ushort GameCenterGameComposer = 3805;


        public static const ushort SnowStormGameStartedComposer = 5000;
        public static const ushort SnowStormQuePositionComposer = 5001;
        public static const ushort SnowStormStartBlockTickerComposer = 5002;
        public static const ushort SnowStormStartLobbyCounterComposer = 5003;
        public static const ushort SnowStormUnusedAlertGenericComposer = 5004;
        public static const ushort SnowStormLongDataComposer = 5005;
        public static const ushort SnowStormGameEndedComposer = 5006;
        public static const ushort SnowStormQuePlayerAddedComposer = 5008;
        public static const ushort SnowStormPlayAgainComposer = 5009;
        public static const ushort SnowStormGamesLeftComposer = 5010;
        public static const ushort SnowStormQuePlayerRemovedComposer = 5011;
        public static const ushort SnowStormGamesInformationComposer = 5012;
        public static const ushort SnowStormLongData2Composer = 5013;
        public static const ushort UNUSED_SNOWSTORM_5014 = 5014;
        public static const ushort SnowStormGameStatusComposer = 5015;
        public static const ushort SnowStormFullGameStatusComposer = 5016;
        public static const ushort SnowStormOnStageStartComposer = 5017;
        public static const ushort SnowStormIntializeGameArenaViewComposer = 5018;
        public static const ushort SnowStormRejoinPreviousRoomComposer = 5019;
        public static const ushort UNKNOWN_SNOWSTORM_5020 = 5020;
        public static const ushort SnowStormLevelDataComposer = 5021;
        public static const ushort SnowStormOnGameEndingComposer = 5022;
        public static const ushort SnowStormUserChatMessageComposer = 5023;
        public static const ushort SnowStormOnStageRunningComposer = 5024;
        public static const ushort SnowStormOnStageEndingComposer = 5025;
        public static const ushort SnowStormIntializedPlayersComposer = 5026;
        public static const ushort SnowStormOnPlayerExitedArenaComposer = 5027;
        public static const ushort SnowStormGenericErrorComposer = 5028;
        public static const ushort SnowStormUserRematchedComposer = 5029;

    }
}
