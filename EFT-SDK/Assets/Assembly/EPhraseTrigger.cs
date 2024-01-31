using System;

// Token: 0x02000745 RID: 1861
public enum EPhraseTrigger
{
	// Token: 0x04002A05 RID: 10757
	PhraseNone = 8,
	// Token: 0x04002A06 RID: 10758
	OnAgony,
	// Token: 0x04002A07 RID: 10759
	OnGoodWork,
	// Token: 0x04002A08 RID: 10760
	OnEnemyGrenade,
	// Token: 0x04002A09 RID: 10761
	OnFirstContact,
	// Token: 0x04002A0A RID: 10762
	OnLostVisual,
	// Token: 0x04002A0B RID: 10763
	OnFriendlyDown,
	// Token: 0x04002A0C RID: 10764
	OnBeingHurt,
	// Token: 0x04002A0D RID: 10765
	OnBeingHurtDissapoinment,
	// Token: 0x04002A0E RID: 10766
	OnEnemyConversation,
	// Token: 0x04002A0F RID: 10767
	OnEnemyDown,
	// Token: 0x04002A10 RID: 10768
	OnEnemyShot,
	// Token: 0x04002A11 RID: 10769
	OnOutOfAmmo,
	// Token: 0x04002A12 RID: 10770
	OnRepeatedContact,
	// Token: 0x04002A13 RID: 10771
	OnGrenade,
	// Token: 0x04002A14 RID: 10772
	OnWeaponReload,
	// Token: 0x04002A15 RID: 10773
	OnWeaponJammed,
	// Token: 0x04002A16 RID: 10774
	OnWeaponMisfired,
	// Token: 0x04002A17 RID: 10775
	OnDeath,
	// Token: 0x04002A18 RID: 10776
	OnFight,
	// Token: 0x04002A19 RID: 10777
	OnMutter,
	// Token: 0x04002A1A RID: 10778
	OnBreath,
	// Token: 0x04002A1B RID: 10779
	CoverMe,
	// Token: 0x04002A1C RID: 10780
	FollowMe,
	// Token: 0x04002A1D RID: 10781
	GetBack,
	// Token: 0x04002A1E RID: 10782
	GoForward,
	// Token: 0x04002A1F RID: 10783
	Gogogo,
	// Token: 0x04002A20 RID: 10784
	Attention,
	// Token: 0x04002A21 RID: 10785
	HoldPosition,
	// Token: 0x04002A22 RID: 10786
	GoLoot,
	// Token: 0x04002A23 RID: 10787
	Stop,
	// Token: 0x04002A24 RID: 10788
	Silence,
	// Token: 0x04002A25 RID: 10789
	OnYourOwn,
	// Token: 0x04002A26 RID: 10790
	Fire,
	// Token: 0x04002A27 RID: 10791
	HoldFire,
	// Token: 0x04002A28 RID: 10792
	Suppress,
	// Token: 0x04002A29 RID: 10793
	Spreadout,
	// Token: 0x04002A2A RID: 10794
	GetInCover,
	// Token: 0x04002A2B RID: 10795
	KnifesOnly,
	// Token: 0x04002A2C RID: 10796
	Regroup,
	// Token: 0x04002A2D RID: 10797
	HandBroken,
	// Token: 0x04002A2E RID: 10798
	LegBroken,
	// Token: 0x04002A2F RID: 10799
	Bleeding,
	// Token: 0x04002A30 RID: 10800
	Dehydrated,
	// Token: 0x04002A31 RID: 10801
	Exhausted,
	// Token: 0x04002A32 RID: 10802
	HurtLight,
	// Token: 0x04002A33 RID: 10803
	HurtMedium,
	// Token: 0x04002A34 RID: 10804
	HurtHeavy,
	// Token: 0x04002A35 RID: 10805
	HurtNearDeath,
	// Token: 0x04002A36 RID: 10806
	StartHeal = 106,
	// Token: 0x04002A37 RID: 10807
	DontKnow = 57,
	// Token: 0x04002A38 RID: 10808
	Clear,
	// Token: 0x04002A39 RID: 10809
	Going,
	// Token: 0x04002A3A RID: 10810
	Covering,
	// Token: 0x04002A3B RID: 10811
	BadWork,
	// Token: 0x04002A3C RID: 10812
	Negative,
	// Token: 0x04002A3D RID: 10813
	Ready,
	// Token: 0x04002A3E RID: 10814
	OnPosition,
	// Token: 0x04002A3F RID: 10815
	OnLoot,
	// Token: 0x04002A40 RID: 10816
	GoodWork,
	// Token: 0x04002A41 RID: 10817
	Roger,
	// Token: 0x04002A42 RID: 10818
	Repeat,
	// Token: 0x04002A43 RID: 10819
	Toxic = 107,
	// Token: 0x04002A44 RID: 10820
	LeftFlank = 69,
	// Token: 0x04002A45 RID: 10821
	Scav,
	// Token: 0x04002A46 RID: 10822
	SniperPhrase,
	// Token: 0x04002A47 RID: 10823
	RightFlank,
	// Token: 0x04002A48 RID: 10824
	InTheFront,
	// Token: 0x04002A49 RID: 10825
	OnSix,
	// Token: 0x04002A4A RID: 10826
	UnderFire = 105,
	// Token: 0x04002A4B RID: 10827
	EnemyDown = 75,
	// Token: 0x04002A4C RID: 10828
	ScavDown,
	// Token: 0x04002A4D RID: 10829
	LostVisual,
	// Token: 0x04002A4E RID: 10830
	EnemyHit,
	// Token: 0x04002A4F RID: 10831
	KnifeKill,
	// Token: 0x04002A50 RID: 10832
	NoisePhrase,
	// Token: 0x04002A51 RID: 10833
	FriendlyFire,
	// Token: 0x04002A52 RID: 10834
	Rat,
	// Token: 0x04002A53 RID: 10835
	Down,
	// Token: 0x04002A54 RID: 10836
	Hit,
	// Token: 0x04002A55 RID: 10837
	NeedFrag,
	// Token: 0x04002A56 RID: 10838
	NeedSniper,
	// Token: 0x04002A57 RID: 10839
	NeedAmmo,
	// Token: 0x04002A58 RID: 10840
	NeedHelp,
	// Token: 0x04002A59 RID: 10841
	NeedWeapon,
	// Token: 0x04002A5A RID: 10842
	NeedMedkit,
	// Token: 0x04002A5B RID: 10843
	ExitLocated,
	// Token: 0x04002A5C RID: 10844
	LootKey,
	// Token: 0x04002A5D RID: 10845
	LockedDoor,
	// Token: 0x04002A5E RID: 10846
	LootBody,
	// Token: 0x04002A5F RID: 10847
	LootContainer,
	// Token: 0x04002A60 RID: 10848
	LootGeneric,
	// Token: 0x04002A61 RID: 10849
	LootMoney,
	// Token: 0x04002A62 RID: 10850
	LootWeapon,
	// Token: 0x04002A63 RID: 10851
	Cooperation,
	// Token: 0x04002A64 RID: 10852
	LootNothing,
	// Token: 0x04002A65 RID: 10853
	WeaponBroken,
	// Token: 0x04002A66 RID: 10854
	OpenDoor,
	// Token: 0x04002A67 RID: 10855
	CheckHim,
	// Token: 0x04002A68 RID: 10856
	MumblePhrase
}
