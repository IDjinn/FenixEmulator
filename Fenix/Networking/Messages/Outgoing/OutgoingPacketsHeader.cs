using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Networking.Messages.Outgoing
{
    public static class OutgoingPacketsHeader
    {
        public const short PetStatusUpdateComposer = 1907;//error 404

        public const short CfhTopicsMessageComposer = 325;
        public const short FavoriteRoomsCountComposer = 151;
        public const short UserCurrencyComposer = 2018;
        public const short RedeemVoucherOKComposer = 3336;
        public const short RoomUserShoutComposer = 1036;
        public const short RoomUserStatusComposer = 1640;
        public const short RoomUserDataComposer = 3920;
        public const short RoomAddRightsListComposer = 2088;
        public const short RoomRemoveRightsListComposer = 1327;
        public const short RoomRightsListComposer = 1284;
        public const short RoomUserHandItemComposer = 1474;
        public const short RoomUsersComposer = 374;
        public const short FriendRequestComposer = 2219;
        public const short GuildBoughtComposer = 2808;
        public const short AddUserBadgeComposer = 2493;
        public const short RecyclerCompleteComposer = 468;
        public const short GuildBuyRoomsComposer = 2159;
        public const short FriendsComposer = 3130;
        public const short StalkErrorComposer = 3048;
        public const short TradeCloseWindowComposer = 1001;
        public const short RemoveFloorItemComposer = 2703;
        public const short InventoryPetsComposer = 3522;
        public const short UserCreditsComposer = 3475;
        public const short WiredTriggerDataComposer = 383;
        public const short TradeStoppedComposer = 1373;
        public const short ModToolUserChatlogComposer = 3377;
        public const short GuildInfoComposer = 1702;
        public const short UserPermissionsComposer = 411;
        public const short PetNameErrorComposer = 1503;
        public const short TradeStartFailComposer = 217;
        public const short AddHabboItemComposer = 2103;
        public const short InventoryBotsComposer = 3086;
        public const short CanCreateRoomComposer = 378;
        public const short MarketplaceBuyErrorComposer = 2032;
        public const short BonusRareComposer = 1533;
        public const short HotelViewComposer = 122;
        public const short UpdateFriendComposer = 2800;
        public const short FloorItemUpdateComposer = 3776;
        public const short RoomAccessDeniedComposer = 878;
        public const short GuildFurniWidgetComposer = 3293;
        public const short GiftConfigurationComposer = 2234;
        public const short UserClubComposer = 954;
        public const short InventoryBadgesComposer = 717;
        public const short RoomUserTypingComposer = 1717;
        public const short GuildJoinErrorComposer = 762;
        public const short RoomCategoriesComposer = 1562;
        public const short InventoryAchievementsComposer = 2501;
        public const short MarketplaceItemInfoComposer = 725;
        public const short RoomRelativeMapComposer = 2753;
        public const short ModToolComposerTwo = 2335;
        public const short ModToolComposerOne = 3192;
        public const short RoomRightsComposer = 780;
        public const short ObjectOnRollerComposer = 3207;
        public const short PollStartComposer = 3785;
        public const short GuildRefreshMembersListComposer = 2445;
        public const short UserPerksComposer = 2586;
        public const short UserCitizinShipComposer = 1203;
        public const short PublicRoomsComposer = short.MinValue;//error 404
        public const short MarketplaceOffersComposer = 680;
        public const short ModToolComposer = 2696;
        public const short UserBadgesComposer = 1087;
        public const short GuildManageComposer = 3965;
        public const short RemoveFriendComposer = short.MinValue;//error 404
        public const short InitDiffieHandshakeComposer = 1347;
        public const short CompleteDiffieHandshakeComposer = 3885;
        public const short UserDataComposer = 2725;
        public const short UserSearchResultComposer = 973;
        public const short ModToolUserRoomVisitsComposer = 1752;
        public const short RoomUserRespectComposer = 2815;
        public const short RoomChatSettingsComposer = 1191;
        public const short RemoveHabboItemComposer = 159;
        public const short RoomUserRemoveComposer = 2661;
        public const short RoomHeightMapComposer = 1301;
        public const short RoomPetHorseFigureComposer = 1924;
        public const short PetErrorComposer = 2913;
        public const short TradeUpdateComposer = 2024;
        public const short PrivateRoomsComposer = 52;
        public const short RoomModelComposer = 2031;
        public const short RoomScoreComposer = 482;
        public const short DoorbellAddUserComposer = 2309;
        public const short SecureLoginOKComposer = 2491;
        public const short SessionRightsComposer = 2033;
        public const short GuildMemberUpdateComposer = 265;
        public const short RoomFloorItemsComposer = 1778;
        public const short InventoryItemsComposer = 994;
        public const short RoomUserTalkComposer = 1446;
        public const short TradeStartComposer = 2505;
        public const short InventoryItemUpdateComposer = 104;
        public const short ModToolIssueUpdateComposer = 3150;
        public const short MeMenuSettingsComposer = 513;
        public const short ModToolRoomInfoComposer = 1333;
        public const short GuildListComposer = 420;
        public const short RecyclerLogicComposer = 3164;
        public const short UserHomeRoomComposer = 2875;
        public const short RoomUserDanceComposer = 2233;
        public const short RoomSettingsUpdatedComposer = 3297;
        public const short AlertPurchaseFailedComposer = 1404;
        public const short RoomDataComposer = 687;
        public const short TagsComposer = 2012;
        public const short InventoryRefreshComposer = 3151; // PRODUCTION-201611291003-338511768
        public const short RemovePetComposer = 3253; // PRODUCTION-201611291003-338511768
        public const short RemoveWallItemComposer = 3208; // PRODUCTION-201611291003-338511768
        public const short TradeCompleteComposer = 2369; // PRODUCTION-201611291003-338511768
        public const short NewsWidgetsComposer = 286; // PRODUCTION-201611291003-338511768
        public const short WiredEffectDataComposer = 1434; // PRODUCTION-201611291003-338511768
        public const short BubbleAlertComposer = 1992; // PRODUCTION-201611291003-338511768
        public const short ReloadRecyclerComposer = 3433; // PRODUCTION-201611291003-338511768
        public const short MoodLightDataComposer = 2710; // PRODUCTION-201611291003-338511768
        public const short WiredRewardAlertComposer = 178; // PRODUCTION-201611291003-338511768
        public const short CatalogPageComposer = 804; // PRODUCTION-201611291003-338511768
        public const short CatalogModeComposer = 3828; // PRODUCTION-201611291003-338511768
        public const short ChangeNameUpdateComposer = 118; // PRODUCTION-201611291003-338511768
        public const short AddFloorItemComposer = 1534; // PRODUCTION-201611291003-338511768
        public const short DebugConsoleComposer = 3284; // PRODUCTION-201611291003-338511768
        public const short HallOfFameComposer = 3005; // PRODUCTION-201611291003-338511768
        public const short WiredSavedComposer = 1155; // PRODUCTION-201611291003-338511768
        public const short RoomPaintComposer = 2454; // PRODUCTION-201611291003-338511768
        public const short MarketplaceConfigComposer = 1823; // PRODUCTION-201611291003-338511768
        public const short AddBotComposer = 1352; // PRODUCTION-201611291003-338511768
        public const short FriendRequestErrorComposer = 892; // PRODUCTION-201611291003-338511768
        public const short GuildMembersComposer = 1200; // PRODUCTION-201611291003-338511768
        public const short RoomOpenComposer = 758; // PRODUCTION-201611291003-338511768
        public const short ModToolRoomChatlogComposer = 3434; // PRODUCTION-201611291003-338511768
        public const short DiscountComposer = 2347; // PRODUCTION-201611291003-338511768
        public const short MarketplaceCancelSaleComposer = 3264; // PRODUCTION-201611291003-338511768
        public const short RoomPetRespectComposer = 2788; // PRODUCTION-201611291003-338511768
        public const short RoomSettingsComposer = 1498; // PRODUCTION-201611291003-338511768
        public const short TalentTrackComposer = 3406; // PRODUCTION-201611291003-338511768
        public const short CatalogPagesListComposer = 1032; // PRODUCTION-201611291003-338511768
        public const short AlertLimitedSoldOutComposer = 377; // PRODUCTION-201611291003-338511768
        public const short CatalogUpdatedComposer = 1866; // PRODUCTION-201611291003-338511768
        public const short PurchaseOKComposer = 869; // PRODUCTION-201611291003-338511768
        public const short WallItemUpdateComposer = 2009; // PRODUCTION-201611291003-338511768
        public const short TradeAcceptedComposer = 2568; // PRODUCTION-201611291003-338511768
        public const short AddWallItemComposer = 2187; // PRODUCTION-201611291003-338511768
        public const short RoomEntryInfoComposer = short.MinValue; // PRODUCTION-201611291003-338511768
        public const short HotelViewDataComposer = 1745; // PRODUCTION-201611291003-338511768
        public const short PresentItemOpenedComposer = 56; // PRODUCTION-201611291003-338511768
        public const short RoomUserRemoveRightsComposer = 84; // PRODUCTION-201611291003-338511768
        public const short UserBCLimitsComposer = short.MinValue; // PRODUCTION-201611291003-338511768
        public const short PetTrainingPanelComposer = 1164; // PRODUCTION-201611291003-338511768
        public const short RoomPaneComposer = 749; // PRODUCTION-201611291003-338511768
        public const short RedeemVoucherErrorComposer = 714; // PRODUCTION-201611291003-338511768
        public const short RoomCreatedComposer = 1304; // PRODUCTION-201611291003-338511768
        public const short GenericAlertComposer = 3801; // PRODUCTION-201611291003-338511768
        public const short GroupPartsComposer = 2238; // PRODUCTION-201611291003-338511768
        public const short ModToolIssueInfoComposer = 3609; // PRODUCTION-201611291003-338511768
        public const short RoomUserWhisperComposer = 2704; // PRODUCTION-201611291003-338511768
        public const short BotErrorComposer = 639; // PRODUCTION-201611291003-338511768
        public const short FreezeLivesComposer = 2324; // PRODUCTION-201611291003-338511768
        public const short LoadFriendRequestsComposer = 280; // PRODUCTION-201611291003-338511768
        public const short MarketplaceSellItemComposer = 54; // PRODUCTION-201611291003-338511768
        public const short ClubDataComposer = 2405; // PRODUCTION-201611291003-338511768
        public const short ProfileFriendsComposer = 2016; // PRODUCTION-201611291003-338511768
        public const short MarketplaceOwnItemsComposer = 3884; // PRODUCTION-201611291003-338511768
        public const short RoomOwnerComposer = 339; // PRODUCTION-201611291003-338511768
        public const short WiredConditionDataComposer = 1108; // PRODUCTION-201611291003-338511768
        public const short ModToolUserInfoComposer = 2866; // PRODUCTION-201611291003-338511768
        public const short UserWardrobeComposer = 3315; // PRODUCTION-201611291003-338511768
        public const short RoomPetExperienceComposer = 2156; // PRODUCTION-201611291003-338511768
        public const short FriendChatMessageComposer = 1587; // PRODUCTION-201611291003-338511768
        public const short PetInformationComposer = 2901; // PRODUCTION-201611291003-338511768
        public const short RoomThicknessComposer = 3547; // PRODUCTION-201611291003-338511768
        public const short AddPetComposer = 2101; // PRODUCTION-201611291003-338511768
        public const short UpdateStackHeightComposer = 558; // PRODUCTION-201611291003-338511768
        public const short RemoveBotComposer = 233; // PRODUCTION-201611291003-338511768
        public const short RoomEnterErrorComposer = 899; // PRODUCTION-201611291003-338511768
        public const short PollQuestionsComposer = 2997; // PRODUCTION-201611291003-338511768
        public const short GenericErrorMessages = 1600; // PRODUCTION-201611291003-338511768
        public const short RoomWallItemsComposer = 1369; // PRODUCTION-201611291003-338511768
        public const short RoomUserEffectComposer = 1167; // PRODUCTION-201611291003-338511768
        public const short PetBreedsComposer = 3331; // PRODUCTION-201611291003-338511768
        public const short ModToolIssueChatlogComposer = 607; // PRODUCTION-201611291003-338511768
        public const short RoomUserActionComposer = 1631; // PRODUCTION-201611291003-338511768
        public const short BotSettingsComposer = 1618; // PRODUCTION-201611291003-338511768
        public const short UserProfileComposer = 3898; // PRODUCTION-201611291003-338511768
        public const short MinimailCountComposer = 2803; // PRODUCTION-201611291003-338511768
        public const short UserAchievementScoreComposer = 1968; // PRODUCTION-201611291003-338511768
        public const short PetLevelUpComposer = 859; // PRODUCTION-201611291003-338511768
        public const short UserPointsComposer = 2275; // PRODUCTION-201611291003-338511768
        public const short ReportRoomFormComposer = 1121; // PRODUCTION-201611291003-338511768
        public const short ModToolIssueHandledComposer = 934; // PRODUCTION-201611291003-338511768
        public const short FloodCounterComposer = 566; // PRODUCTION-201611291003-338511768
        public const short UpdateFailedComposer = 156; // PRODUCTION-201611291003-338511768
        public const short FloorPlanEditorDoorSettingsComposer = 1664; // PRODUCTION-201611291003-338511768
        public const short FloorPlanEditorBlockedTilesComposer = 3990; // PRODUCTION-201611291003-338511768
        public const short BuildersClubExpiredComposer = 1452; // PRODUCTION-201611291003-338511768
        public const short RoomSettingsSavedComposer = 948; // PRODUCTION-201611291003-338511768
        public const short MessengerInitComposer = 1605; // PRODUCTION-201611291003-338511768
        public const short UserClothesComposer = 1450; // PRODUCTION-201611291003-338511768
        public const short UserEffectsListComposer = 340; // PRODUCTION-201611291003-338511768
        public const short NewUserIdentityComposer = 3738; // PRODUCTION-201611291003-338511768
        public const short NewNavigatorEventCategoriesComposer = 3244; // PRODUCTION-201611291003-338511768
        public const short NewNavigatorCollapsedCategoriesComposer = 1543; // PRODUCTION-201611291003-338511768
        public const short NewNavigatorLiftedRoomsComposer = 3104; // PRODUCTION-201611291003-338511768
        public const short NewNavigatorSavedSearchesComposer = 3984; // PRODUCTION-201611291003-338511768
        public const short PostItDataComposer = 2202; // PRODUCTION-201611291003-338511768
        public const short ModToolReportReceivedAlertComposer = 3635; // PRODUCTION-201611291003-338511768
        public const short ModToolIssueResponseAlertComposer = 3796; // PRODUCTION-201611291003-338511768
        public const short AchievementListComposer = 305; // PRODUCTION-201611291003-338511768
        public const short AchievementProgressComposer = 2107; // PRODUCTION-201611291003-338511768
        public const short AchievementUnlockedComposer = 806; // PRODUCTION-201611291003-338511768
        public const short ClubGiftsComposer = 619; // PRODUCTION-201611291003-338511768
        public const short MachineIDComposer = 1488; // PRODUCTION-201611291003-338511768
        public const short PongComposer = 10; // PRODUCTION-201611291003-338511768
        public const short ModToolIssueHandlerDimensionsComposer = 1576; // PRODUCTION-201611291003-338511768

        //Uknown but work
        public const short IsFirstLoginOfDayComposer = 793; // PRODUCTION-201611291003-338511768 //Quest Engine
        public const short UnknownComposer5 = 2833; // PRODUCTION-201611291003-338511768 //Mysterbox
        public const short IgnoredUsersComposer = 126; // PRODUCTION-201611291003-338511768
        public const short NewNavigatorMetaDataComposer = 3052; // PRODUCTION-201611291003-338511768
        public const short NewNavigatorSearchResultsComposer = 2690; // PRODUCTION-201611291003-338511768
        public const short MysticBoxStartOpenComposer = 3201; // PRODUCTION-201611291003-338511768
        public const short MysticBoxCloseComposer = 596; // PRODUCTION-201611291003-338511768
        public const short MysticBoxPrizeComposer = 3712; // PRODUCTION-201611291003-338511768
        public const short RentableSpaceInfoComposer = 3559; // PRODUCTION-201611291003-338511768
        public const short RentableSpaceUnknownComposer = 2046; // PRODUCTION-201611291003-338511768
        public const short RentableSpaceUnknown2Composer = 1868; // PRODUCTION-201611291003-338511768
        public const short GuildConfirmRemoveMemberComposer = 1876; // PRODUCTION-201611291003-338511768

        public const short HotelViewBadgeButtonConfigComposer = 2998; // PRODUCTION-201611291003-338511768
        public const short EpicPopupFrameComposer = 3945; // PRODUCTION-201611291003-338511768
        public const short BaseJumpLoadGameURLComposer = 2624; // PRODUCTION-201611291003-338511768
        public const short RoomUserTagsComposer = 1255; // PRODUCTION-201611291003-338511768
        public const short RoomInviteErrorComposer = 462; // PRODUCTION-201611291003-338511768
        public const short PostItStickyPoleOpenComposer = 2366; // PRODUCTION-201611291003-338511768
        public const short NewYearResolutionProgressComposer = 3370; // PRODUCTION-201611291003-338511768
        public const short ClubGiftReceivedComposer = 659; // PRODUCTION-201611291003-338511768
        public const short ItemStateComposer = 2376; // PRODUCTION-201611291003-338511768
        public const short ItemExtraDataComposer = 2547; // PRODUCTION-201611291003-338511768
        public const short PostUpdateMessageComposer = 324; // PRODUCTION-201611291003-338511768
                                                                 //NotSure Needs Testing
        public const short QuestionInfoComposer = short.MinValue; // PRODUCTION-201611291003-338511768
        public const short TalentTrackEmailVerifiedComposer = 612; // PRODUCTION-201611291003-338511768
        public const short TalentTrackEmailFailedComposer = 1815; // PRODUCTION-201611291003-338511768
        public const short UnknownAvatarEditorComposer = 3473; // PRODUCTION-201611291003-338511768

        public const short GuildMembershipRequestedComposer = 1180; // PRODUCTION-201611291003-338511768

        public const short GuildForumsUnreadMessagesCountComposer = 2379; // PRODUCTION-201611291003-338511768
        public const short GuildForumThreadMessagesComposer = 1862; // PRODUCTION-201611291003-338511768
        public const short GuildForumAddCommentComposer = 2049; // PRODUCTION-201611291003-338511768
        public const short GuildForumDataComposer = 3011; // PRODUCTION-201611291003-338511768
        public const short GuildForumCommentsComposer = 509; // PRODUCTION-201611291003-338511768
        public const short UnknownGuildForumComposer6 = short.MinValue; // PRODUCTION-201611291003-338511768
        public const short UnknownGuildForumComposer7 = short.MinValue; // PRODUCTION-201611291003-338511768
        public const short GuildForumThreadsComposer = 1073; // PRODUCTION-201611291003-338511768
        public const short GuildForumListComposer = 3001; // PRODUCTION-201611291003-338511768
        public const short ThreadUpdateMessageComposer = 2528;
        public const short GuideSessionAttachedComposer = 1591; // PRODUCTION-201611291003-338511768
        public const short GuideSessionDetachedComposer = 138; // PRODUCTION-201611291003-338511768
        public const short GuideSessionStartedComposer = 3209; // PRODUCTION-201611291003-338511768
        public const short GuideSessionEndedComposer = 1456; // PRODUCTION-201611291003-338511768
        public const short GuideSessionErrorComposer = 673; // PRODUCTION-201611291003-338511768
        public const short GuideSessionMessageComposer = 841; // PRODUCTION-201611291003-338511768
        public const short GuideSessionRequesterRoomComposer = 1847; // PRODUCTION-201611291003-338511768
        public const short GuideSessionInvitedToGuideRoomComposer = 219; // PRODUCTION-201611291003-338511768
        public const short GuideSessionPartnerIsTypingComposer = 1016; // PRODUCTION-201611291003-338511768

        public const short GuideToolsComposer = 1548; // PRODUCTION-201611291003-338511768
        public const short GuardianNewReportReceivedComposer = 735; // PRODUCTION-201611291003-338511768
        public const short GuardianVotingRequestedComposer = 143; // PRODUCTION-201611291003-338511768
        public const short GuardianVotingVotesComposer = 1829; // PRODUCTION-201611291003-338511768
        public const short GuardianVotingResultComposer = 3276; // PRODUCTION-201611291003-338511768
        public const short GuardianVotingTimeEnded = 30; // PRODUCTION-201611291003-338511768

        public const short RoomMutedComposer = 2533; // PRODUCTION-201611291003-338511768

        public const short HideDoorbellComposer = 3783; // PRODUCTION-201611291003-338511768
        public const short RoomQueueStatusMessage = 2208; // PRODUCTION-201611291003-338511768
        public const short RoomUnknown3Composer = 1033; // PRODUCTION-201611291003-338511768

        public const short EffectsListRemoveComposer = 2228; // PRODUCTION-201611291003-338511768

        public const short OldPublicRoomsComposer = 2726; // PRODUCTION-201611291003-338511768
        public const short ItemStateComposer2 = 3431; // PRODUCTION-201611291003-338511768

        public const short HotelWillCloseInMinutesComposer = 1050; // PRODUCTION-201611291003-338511768
        public const short HotelWillCloseInMinutesAndBackInComposer = 1350; // PRODUCTION-201611291003-338511768
        public const short HotelClosesAndWillOpenAtComposer = 2771; // PRODUCTION-201611291003-338511768
        public const short HotelClosedAndOpensComposer = 3728; // PRODUCTION-201611291003-338511768
        public const short StaffAlertAndOpenHabboWayComposer = 1683; // PRODUCTION-201611291003-338511768
        public const short StaffAlertWithLinkComposer = 2030; // PRODUCTION-201611291003-338511768
        public const short StaffAlertWIthLinkAndOpenHabboWayComposer = 1890; // PRODUCTION-201611291003-338511768

        public const short RoomMessagesPostedCountComposer = 1634; // PRODUCTION-201611291003-338511768
        public const short CantScratchPetNotOldEnoughComposer = 1130; // PRODUCTION-201611291003-338511768
        public const short PetBoughtNotificationComposer = 1111; // PRODUCTION-201611291003-338511768
        public const short MessagesForYouComposer = 2035; // PRODUCTION-201611291003-338511768
        public const short UnknownStatusComposer = 1243; // PRODUCTION-201611291003-338511768
        public const short CloseWebPageComposer = 426; // PRODUCTION-201611291003-338511768
        public const short PickMonthlyClubGiftNotificationComposer = 2188; // PRODUCTION-201611291003-338511768
        public const short RemoveGuildFromRoomComposer = 3129; // PRODUCTION-201611291003-338511768
        public const short RoomBannedUsersComposer = 1869; // PRODUCTION-201611291003-338511768
        public const short OpenRoomCreationWindowComposer = 2064; // PRODUCTION-201611291003-338511768
        public const short ItemsDataUpdateComposer = 1453; // PRODUCTION-201611291003-338511768
        public const short WelcomeGiftComposer = 2707; // PRODUCTION-201611291003-338511768
        public const short SimplePollStartComposer = 2665; // PRODUCTION-201611291003-338511768
        public const short RoomNoRightsComposer = 2392; // PRODUCTION-201611291003-338511768
        public const short GuildEditFailComposer = 3988; // PRODUCTION-201611291003-338511768
        public const short MinimailNewMessageComposer = 1911; // PRODUCTION-201611291003-338511768
        public const short RoomFilterWordsComposer = 2937; // PRODUCTION-201611291003-338511768
        public const short VerifyMobileNumberComposer = 3639; // PRODUCTION-201611291003-338511768
        public const short NewUserGiftComposer = 3575; // PRODUCTION-201611291003-338511768
        public const short UpdateUserLookComposer = 2429; // PRODUCTION-201611291003-338511768
        public const short RoomUserIgnoredComposer = 207; // PRODUCTION-201611291003-338511768
        public const short PetBreedingFailedComposer = 1625; // PRODUCTION-201611291003-338511768
        public const short RoomUserNameChangedComposer = 2182; // PRODUCTION-201611291003-338511768
        public const short LoveLockFurniStartComposer = 3753; // PRODUCTION-201611291003-338511768
        public const short LoveLockFurniFriendConfirmedComposer = 382; // PRODUCTION-201611291003-338511768
        public const short LoveLockFurniFinishedComposer = 770; // PRODUCTION-201611291003-338511768
        public const short PetPackageNameValidationComposer = 546; // PRODUCTION-201611291003-338511768
        public const short GameCenterFeaturedPlayersComposer = 3097; // PRODUCTION-201611291003-338511768
        public const short HabboMallComposer = 1237; // PRODUCTION-201611291003-338511768
        public const short TargetedOfferComposer = 119; // PRODUCTION-201611291003-338511768
        public const short LeprechaunStarterBundleComposer = 2380; // PRODUCTION-201611291003-338511768
        public const short VerifyMobilePhoneWindowComposer = 2890; // PRODUCTION-201611291003-338511768
        public const short VerifyMobilePhoneCodeWindowComposer = 800; // PRODUCTION-201611291003-338511768
        public const short VerifyMobilePhoneDoneComposer = 91; // PRODUCTION-201611291003-338511768
        public const short RoomUserReceivedHandItemComposer = 354; // PRODUCTION-201611291003-338511768
        public const short MutedWhisperComposer = 826; // PRODUCTION-201611291003-338511768
        public const short UnknownHintComposer = 1787; // PRODUCTION-201611291003-338511768
        public const short BullyReportClosedComposer = 2674; // PRODUCTION-201611291003-338511768
        public const short PromoteOwnRoomsListComposer = 2468; // PRODUCTION-201611291003-338511768
        public const short NotEnoughPointsTypeComposer = 3914; // PRODUCTION-201611291003-338511768
        public const short WatchAndEarnRewardComposer = 2125; // PRODUCTION-201611291003-338511768
        public const short NewYearResolutionComposer = 66; // PRODUCTION-201611291003-338511768
        public const short WelcomeGiftErrorComposer = 2293; // PRODUCTION-201611291003-338511768
        public const short RentableItemBuyOutPriceComposer = 35; // PRODUCTION-201611291003-338511768
        public const short VipTutorialsStartComposer = 2278; // PRODUCTION-201611291003-338511768
        public const short NewNavigatorCategoryUserCountComposer = 1455; // PRODUCTION-201611291003-338511768
        public const short CameraRoomThumbnailSavedComposer = 3595; // PRODUCTION-201611291003-338511768
        public const short RoomEditSettingsErrorComposer = 1555; // PRODUCTION-201611291003-338511768
        public const short GuildAcceptMemberErrorComposer = 818; // PRODUCTION-201611291003-338511768
        public const short MostUselessErrorAlertComposer = 662; // PRODUCTION-201611291003-338511768
        public const short AchievementsConfigurationComposer = 1689; // PRODUCTION-201611291003-338511768
        public const short PetBreedingResultComposer = 634; // PRODUCTION-201611291003-338511768
        public const short RoomUserQuestionAnsweredComposer = short.MinValue; // PRODUCTION-201611291003-338511768
        public const short PetBreedingStartComposer = 1746; // PRODUCTION-201611291003-338511768
        public const short CustomNotificationComposer = 909; // PRODUCTION-201611291003-338511768
        public const short UpdateStackHeightTileHeightComposer = 2816; // PRODUCTION-201611291003-338511768
        public const short HotelViewCustomTimerComposer = short.MinValue; // PRODUCTION-201611291003-338511768
        public const short MarketplaceItemPostedComposer = 1359; // PRODUCTION-201611291003-338511768
        public const short HabboWayQuizComposer2 = 2927; // PRODUCTION-201611291003-338511768
        public const short GuildFavoriteRoomUserUpdateComposer = 3403; // PRODUCTION-201611291003-338511768
        public const short RoomAdErrorComposer = 1759; // PRODUCTION-201611291003-338511768
        public const short NewNavigatorSettingsComposer = 518; // PRODUCTION-201611291003-338511768
        public const short CameraPublishWaitMessageComposer = 2057; // PRODUCTION-201611291003-338511768
        public const short RoomInviteComposer = 3870; // PRODUCTION-201611291003-338511768
        public const short BullyReportRequestComposer = 3463; // PRODUCTION-201611291003-338511768
        public const short UnknownHelperComposer = 77; // PRODUCTION-201611291003-338511768
        public const short HelperRequestDisabledComposer = 1651; // PRODUCTION-201611291003-338511768
        public const short RoomUnitIdleComposer = 1797; // PRODUCTION-201611291003-338511768
        public const short QuestCompletedComposer = 949; // PRODUCTION-201611291003-338511768
        public const short UnkownPetPackageComposer = 1723; // PRODUCTION-201611291003-338511768
        public const short ForwardToRoomComposer = 160; // PRODUCTION-201611291003-338511768
        public const short EffectsListEffectEnableComposer = 1959; // PRODUCTION-201611291003-338511768
        public const short CompetitionEntrySubmitResultComposer = 1177; // PRODUCTION-201611291003-338511768
        public const short ExtendClubMessageComposer = 3964; // PRODUCTION-201611291003-338511768
        public const short HotelViewConcurrentUsersComposer = 2737; // PRODUCTION-201611291003-338511768
        public const short InventoryAddEffectComposer = short.MinValue;//error 404
        public const short TalentLevelUpdateComposer = 638; // PRODUCTION-201611291003-338511768
        public const short BullyReportedMessageComposer = 3285; // PRODUCTION-201611291003-338511768
        public const short UnknownQuestComposer3 = 1122; // PRODUCTION-201611291003-338511768
        public const short FriendToolbarNotificationComposer = 3082; // PRODUCTION-201611291003-338511768
        public const short MessengerErrorComposer = 896; // PRODUCTION-201611291003-338511768
        public const short CameraPriceComposer = 3878; // PRODUCTION-201611291003-338511768
        public const short PetBreedingCompleted = 2527; // PRODUCTION-201611291003-338511768
        public const short RoomUserUnbannedComposer = 3429; // PRODUCTION-201611291003-338511768
        public const short HotelViewCommunityGoalComposer = 2525; // PRODUCTION-201611291003-338511768
        public const short UserClassificationComposer = 966; // PRODUCTION-201611291003-338511768
        public const short CanCreateEventComposer = 2599; // PRODUCTION-201611291003-338511768
        public const short UnknownGuild2Composer = 1459; // PRODUCTION-201611291003-338511768
        public const short YoutubeDisplayListComposer = 1112; // PRODUCTION-201611291003-338511768
        public const short YoutubeMessageComposer2 = 1411; // PRODUCTION-201611291003-338511768
        public const short YoutubeMessageComposer3 = 1554; // PRODUCTION-201611291003-338511768
        public const short RoomCategoryUpdateMessageComposer = 3896; // PRODUCTION-201611291003-338511768
        public const short QuestsComposer = 3625; // PRODUCTION-201611291003-338511768
        public const short GiftReceiverNotFoundComposer = 1517; // PRODUCTION-201611291003-338511768
        public const short ConvertedForwardToRoomComposer = 1331; // PRODUCTION-201611291003-338511768
        public const short FavoriteRoomChangedComposer = 2524; // PRODUCTION-201611291003-338511768
        public const short AlertPurchaseUnavailableComposer = 3770; // PRODUCTION-201611291003-338511768
        public const short PetBreedingStartFailedComposer = 2621; // PRODUCTION-201611291003-338511768
        public const short DailyQuestComposer = 1878; // PRODUCTION-201611291003-338511768
        public const short HotelViewHideCommunityVoteButtonComposer = 1435; // PRODUCTION-201611291003-338511768
        public const short CatalogSearchResultComposer = 3388; // PRODUCTION-201611291003-338511768
        public const short FriendFindingRoomComposer = 1210; // PRODUCTION-201611291003-338511768
        public const short QuestComposer = 230; // PRODUCTION-201611291003-338511768
        public const short ModToolSanctionDataComposer = 2782; // PRODUCTION-201611291003-338511768
        public const short RoomEventMessageComposer = 1840;


        public const short JukeBoxMySongsComposer = 2602; // PRODUCTION-201611291003-338511768
        public const short JukeBoxNowPlayingMessageComposer = 469; // PRODUCTION-201611291003-338511768
        public const short JukeBoxPlaylistFullComposer = 105; // PRODUCTION-201611291003-338511768
        public const short JukeBoxPlayListUpdatedComposer = 1748; // PRODUCTION-201611291003-338511768
        public const short JukeBoxPlayListAddSongComposer = 1140; // PRODUCTION-201611291003-338511768
        public const short JukeBoxPlayListComposer = 34; // PRODUCTION-201611291003-338511768
        public const short JukeBoxTrackDataComposer = 3365; // PRODUCTION-201611291003-338511768
        public const short JukeBoxTrackCodeComposer = 1381; // PRODUCTION-201611291003-338511768


        public const short CraftableProductsComposer = 1000; // PRODUCTION-201611291003-338511768
        public const short CraftingRecipeComposer = 2774; // PRODUCTION-201611291003-338511768
        public const short CraftingResultComposer = 618; // PRODUCTION-201611291003-338511768
        public const short CraftingComposerFour = 2124; // PRODUCTION-201611291003-338511768

        public const short UnknownComposer_100 = 1553; // PRODUCTION-201611291003-338511768 //PetBReedingResult
        public const short ConnectionErrorComposer = 1004; // PRODUCTION-201611291003-338511768
        public const short BotForceOpenContextMenuComposer = 296; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_1111 = 1551; // PRODUCTION-201611291003-338511768
        public const short Game2WeeklyLeaderboardComposer = 2196; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_1165 = 904; // PRODUCTION-201611291003-338511768
        public const short EffectsListAddComposer = 2867; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_1188 = 1437; // PRODUCTION-201611291003-338511768
        public const short SubmitCompetitionRoomComposer = 3841; // PRODUCTION-201611291003-338511768
        public const short GameAchievementsListComposer = 2265; // PRODUCTION-201611291003-338511768
        public const short OtherTradingDisabledComposer = 1254; // PRODUCTION-201611291003-338511768
        public const short BaseJumpUnloadGameComposer = 1715; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_137 = 2897; // PRODUCTION-201611291003-338511768
        public const short GameCenterAccountInfoComposer = 2893; // PRODUCTION-201611291003-338511768
        public const short UnknowComposer_1390 = 2270; // PRODUCTION-201611291003-338511768
        public const short BaseJumpLoadGameComposer = 3654; // PRODUCTION-201611291003-338511768
        public const short UnknowComposer_1427 = 3319; // PRODUCTION-201611291003-338511768
        public const short AdventCalendarDataComposer = 2531; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_152 = 3954; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_1577 = 2641; // PRODUCTION-201611291003-338511768
        public const short NewYearResolutionCompletedComposer = 740; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_1741 = 2246; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_1744 = 2873; // PRODUCTION-201611291003-338511768
        public const short AdventCalendarProductComposer = 2551; // PRODUCTION-201611291003-338511768
        public const short ModToolSanctionInfoComposer = 2221; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_1965 = 3292; // PRODUCTION-201611291003-338511768
        public const short GuideSessionPartnerIsPlayingComposer = 448; // PRODUCTION-201611291003-338511768
        public const short BaseJumpLeaveQueueComposer = 1477; // PRODUCTION-201611291003-338511768
        public const short Game2WeeklySmallLeaderboardComposer = 3512; // PRODUCTION-201611291003-338511768
        public const short GameCenterGameListComposer = 222; // PRODUCTION-201611291003-338511768
        public const short RoomUsersGuildBadgesComposer = 2402; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_2563 = 1774; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_2601 = 1663; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_2621 = 1927; // PRODUCTION-201611291003-338511768
        public const short UnknownComposer_2698 = 563; // PRODUCTION-201611291003-338511768
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
        public const short HabboWayQuizComposer1 = 3379;
        //    3391;
        //    3427;
        //    347;
        //    3509;
        //    3519;
        //    3581;
        //    3684;
        public const short YouTradingDisabledComposer = 3058; // PRODUCTION-201611291003-338511768
                                                                   //    3707;
                                                                   //    3745;
                                                                   //    3759;
                                                                   //    3782;
        public const short RoomFloorThicknessUpdatedComposer = 3786;
        //    3822;
        public const short CameraPurchaseSuccesfullComposer = 2783; // PRODUCTION-201611291003-338511768
        public const short CameraCompetitionStatusComposer = 133; // PRODUCTION-201611291003-338511768
                                                                       //    3986;
                                                                       //    467;
                                                                       //    549;
        public const short CameraURLComposer = 3696; // PRODUCTION-201611291003-338511768
                                                          //    608;
                                                          //    624;
                                                          //    675;
        public const short HotelViewCatalogPageExpiringComposer = 690;
        //    749;
        //    812;
        //    843;
        //    947;
        //    982;


        public const short SimplePollAnswerComposer = 2589;

        public const short SomeConnectionComposer = 3928;
        public const short TradingWaitingConfirmComposer = 2720;
        public const short BaseJumpJoinQueueComposer = 2260;
        public const short ClubCenterDataComposer = 3277;

        public const short SimplePollAnswersComposer = 1066;
        public const short UnknownFurniModelComposer = 1501;
        public const short UnknownAdManagerComposer = 1808;
        public const short WiredOpenComposer = 1830;
        public const short UnknownCatalogPageOfferComposer = 1889;
        public const short NuxAlertComposer = 2023;
        public const short HotelViewExpiringCatalogPageCommposer = 2515;
        public const short UnknownHabboWayQuizComposer = 2772;
        public const short PetLevelUpdatedComposer = 2824;
        public const short QuestExpiredComposer = 3027;
        public const short UnknownTradeComposer = 3128;
        public const short UnknownMessengerErrorComposer = 3359;
        public const short UnknownComposer8 = 3441;
        public const short RemoveRoomEventComposer = 3479;
        public const short UnknownCompetitionComposer = 3506;
        public const short UnknownRoomViewerComposer = 3523;
        public const short ErrorLoginComposer = 4000;
        public const short HotelViewNextLTDAvailableComposer = 44;
        public const short HotelViewSecondsUntilComposer = 3926;
        public const short UnknownRoomDesktopComposer = 69;
        public const short UnknownGuildComposer3 = 876;

        public const short GameCenterGameComposer = 3805;


        public const short SnowStormGameStartedComposer = 5000;
        public const short SnowStormQuePositionComposer = 5001;
        public const short SnowStormStartBlockTickerComposer = 5002;
        public const short SnowStormStartLobbyCounterComposer = 5003;
        public const short SnowStormUnusedAlertGenericComposer = 5004;
        public const short SnowStormLongDataComposer = 5005;
        public const short SnowStormGameEndedComposer = 5006;
        public const short SnowStormQuePlayerAddedComposer = 5008;
        public const short SnowStormPlayAgainComposer = 5009;
        public const short SnowStormGamesLeftComposer = 5010;
        public const short SnowStormQuePlayerRemovedComposer = 5011;
        public const short SnowStormGamesInformationComposer = 5012;
        public const short SnowStormLongData2Composer = 5013;
        public const short UNUSED_SNOWSTORM_5014 = 5014;
        public const short SnowStormGameStatusComposer = 5015;
        public const short SnowStormFullGameStatusComposer = 5016;
        public const short SnowStormOnStageStartComposer = 5017;
        public const short SnowStormIntializeGameArenaViewComposer = 5018;
        public const short SnowStormRejoinPreviousRoomComposer = 5019;
        public const short UNKNOWN_SNOWSTORM_5020 = 5020;
        public const short SnowStormLevelDataComposer = 5021;
        public const short SnowStormOnGameEndingComposer = 5022;
        public const short SnowStormUserChatMessageComposer = 5023;
        public const short SnowStormOnStageRunningComposer = 5024;
        public const short SnowStormOnStageEndingComposer = 5025;
        public const short SnowStormIntializedPlayersComposer = 5026;
        public const short SnowStormOnPlayerExitedArenaComposer = 5027;
        public const short SnowStormGenericErrorComposer = 5028;
        public const short SnowStormUserRematchedComposer = 5029;

    }
}
