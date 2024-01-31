using System;

namespace EFT
{
	// Token: 0x02001276 RID: 4726
	public enum EBackendErrorCode
	{
		// Token: 0x04006F4D RID: 28493
		None,
		// Token: 0x04006F4E RID: 28494
		UnknownError = 200,
		// Token: 0x04006F4F RID: 28495
		NotAuthorized,
		// Token: 0x04006F50 RID: 28496
		NeedAuthorizationCode = 209,
		// Token: 0x04006F51 RID: 28497
		WrongAuthorizationCode = 211,
		// Token: 0x04006F52 RID: 28498
		NeedCaptcha = 214,
		// Token: 0x04006F53 RID: 28499
		NoNeedCaptcha,
		// Token: 0x04006F54 RID: 28500
		CaptchaInvalidAnswer,
		// Token: 0x04006F55 RID: 28501
		CaptchaFailed = 218,
		// Token: 0x04006F56 RID: 28502
		CaptchaBruteForced,
		// Token: 0x04006F57 RID: 28503
		NoRoomInStash = 223,
		// Token: 0x04006F58 RID: 28504
		NicknameNotUnique = 225,
		// Token: 0x04006F59 RID: 28505
		NicknameNotValid,
		// Token: 0x04006F5A RID: 28506
		UnsupportedClientVersion = 232,
		// Token: 0x04006F5B RID: 28507
		ReportNotAllowed = 238,
		// Token: 0x04006F5C RID: 28508
		NicknameIsAbusive = 241,
		// Token: 0x04006F5D RID: 28509
		NicknameChangeTimeout,
		// Token: 0x04006F5E RID: 28510
		NotEnoughSpaceToUnpack = 257,
		// Token: 0x04006F5F RID: 28511
		NotModified = 304,
		// Token: 0x04006F60 RID: 28512
		HTTPBadRequest = 400,
		// Token: 0x04006F61 RID: 28513
		HTTPNotAuthorized,
		// Token: 0x04006F62 RID: 28514
		HTTPForbidden = 403,
		// Token: 0x04006F63 RID: 28515
		HTTPNotFound,
		// Token: 0x04006F64 RID: 28516
		HTTPMethodNotAllowed,
		// Token: 0x04006F65 RID: 28517
		UnknownTradingError = 500,
		// Token: 0x04006F66 RID: 28518
		HTTPNotImplemented,
		// Token: 0x04006F67 RID: 28519
		HTTPBadGateway,
		// Token: 0x04006F68 RID: 28520
		HTTPServiceUnavailable,
		// Token: 0x04006F69 RID: 28521
		HTTPGatewayTimeout,
		// Token: 0x04006F6A RID: 28522
		TraderOutOfMoney,
		// Token: 0x04006F6B RID: 28523
		HTTPVariantAlsoNegotiates,
		// Token: 0x04006F6C RID: 28524
		PriceChanged = 509,
		// Token: 0x04006F6D RID: 28525
		TraderDisabled = 512,
		// Token: 0x04006F6E RID: 28526
		ItemHasBeenSold,
		// Token: 0x04006F6F RID: 28527
		NotEnoughSpaceForMoney = 518,
		// Token: 0x04006F70 RID: 28528
		HTTPInvalidSSLCertificate = 526,
		// Token: 0x04006F71 RID: 28529
		UnknownRagfairError = 550,
		// Token: 0x04006F72 RID: 28530
		UnknownRagfairError2,
		// Token: 0x04006F73 RID: 28531
		UnknownMatchMakerError = 600,
		// Token: 0x04006F74 RID: 28532
		SessionParametersError,
		// Token: 0x04006F75 RID: 28533
		SessionLost,
		// Token: 0x04006F76 RID: 28534
		ServerNotRegistered = 604,
		// Token: 0x04006F77 RID: 28535
		UnknownQuestError = 700,
		// Token: 0x04006F78 RID: 28536
		QuestBadParam = 702,
		// Token: 0x04006F79 RID: 28537
		QuestNotFound,
		// Token: 0x04006F7A RID: 28538
		QuestIsUnavailable,
		// Token: 0x04006F7B RID: 28539
		NoFreeSpaceForRewards,
		// Token: 0x04006F7C RID: 28540
		WrongQuestStatus,
		// Token: 0x04006F7D RID: 28541
		CantCompleteQuest,
		// Token: 0x04006F7E RID: 28542
		UnknownMailError = 900,
		// Token: 0x04006F7F RID: 28543
		TooManyFriendRequests = 925,
		// Token: 0x04006F80 RID: 28544
		UnknownScriptExecutionError = 1000,
		// Token: 0x04006F81 RID: 28545
		UnknownRepairingError = 1200,
		// Token: 0x04006F82 RID: 28546
		UnknownInsuranceError = 1300,
		// Token: 0x04006F83 RID: 28547
		UnknownCurrencyExchangeError = 1400,
		// Token: 0x04006F84 RID: 28548
		OfferNotFound = 1503,
		// Token: 0x04006F85 RID: 28549
		NotEnoughSpace = 1505,
		// Token: 0x04006F86 RID: 28550
		OfferOutOfStock,
		// Token: 0x04006F87 RID: 28551
		OfferSold,
		// Token: 0x04006F88 RID: 28552
		RagfairUnavailable = 1511,
		// Token: 0x04006F89 RID: 28553
		BannedErrorCode = 1513,
		// Token: 0x04006F8A RID: 28554
		InsufficientNumberInStock = 1516,
		// Token: 0x04006F8B RID: 28555
		TooManyItemsToSell,
		// Token: 0x04006F8C RID: 28556
		IncorrectClientPrice = 1519,
		// Token: 0x04006F8D RID: 28557
		ExaminationFailed = 22001,
		// Token: 0x04006F8E RID: 28558
		ItemAlreadyExamined,
		// Token: 0x04006F8F RID: 28559
		UnknownNginxError = 9000,
		// Token: 0x04006F90 RID: 28560
		ParseResponseError,
		// Token: 0x04006F91 RID: 28561
		UnknownMatchmakerError = 503000,
		// Token: 0x04006F92 RID: 28562
		UnknownGroupError = 502000,
		// Token: 0x04006F93 RID: 28563
		GroupRequestNotFound = 502002,
		// Token: 0x04006F94 RID: 28564
		GroupFull = 502004,
		// Token: 0x04006F95 RID: 28565
		PlayerAlreadyInGroup,
		// Token: 0x04006F96 RID: 28566
		PlayerNotInGroup,
		// Token: 0x04006F97 RID: 28567
		PlayerNotLeader,
		// Token: 0x04006F98 RID: 28568
		CantChangeReadyState = 502010,
		// Token: 0x04006F99 RID: 28569
		PlayerForbiddenGroupInvites,
		// Token: 0x04006F9A RID: 28570
		LeaderAlreadyReady,
		// Token: 0x04006F9B RID: 28571
		GroupSendInviteError,
		// Token: 0x04006F9C RID: 28572
		PlayerIsOffline,
		// Token: 0x04006F9D RID: 28573
		PlayerIsNotSearchingForGroup = 502018,
		// Token: 0x04006F9E RID: 28574
		PlayerAlreadyLookingForGame = 503001,
		// Token: 0x04006F9F RID: 28575
		PlayerInRaid,
		// Token: 0x04006FA0 RID: 28576
		LimitForPresetsReached = 504001
	}
}
