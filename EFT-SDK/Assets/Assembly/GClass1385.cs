using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.SynchronizableObjects;

// Token: 0x02001250 RID: 4688
public static class GClass1385
{
	// Token: 0x17000FA3 RID: 4003
	// (get) Token: 0x0600623F RID: 25151 RVA: 0x00002050 File Offset: 0x00000250
	public static ResourceKey PLAYER_BUNDLE_NAME
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000FA4 RID: 4004
	// (get) Token: 0x06006240 RID: 25152 RVA: 0x00002050 File Offset: 0x00000250
	public static ResourceKey PLAYER_DEFAULT_ANIMATOR_CONTROLLER
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000FA5 RID: 4005
	// (get) Token: 0x06006241 RID: 25153 RVA: 0x00002050 File Offset: 0x00000250
	public static ResourceKey BOSS_KABAN_ANIMATOR_CONTROLLER
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000FA6 RID: 4006
	// (get) Token: 0x06006242 RID: 25154 RVA: 0x00002050 File Offset: 0x00000250
	public static ICollection<string> AvailableVoices
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06006243 RID: 25155 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string TakePhrasePath(string name)
	{
		throw null;
	}

	// Token: 0x04006E40 RID: 28224
	public const string DEFAULT_BALLISTIC_COLLIDER = "assets/content/commonprefabs/defaultballisticcollider.bundle";

	// Token: 0x04006E41 RID: 28225
	public const string EFFECTS_BUNDLE_NAME = "assets/systems/effects/particlesystems/effects.bundle";

	// Token: 0x04006E42 RID: 28226
	public const string PLAYER_SPRING_BUNDLE_NAME = "assets/commonassets/player/playerspring.bundle";

	// Token: 0x04006E43 RID: 28227
	public const string PLAYER_SIMPLE_BUNDLE_NAME = "assets/content/commonprefabs/playersimple.bundle";

	// Token: 0x04006E44 RID: 28228
	private static readonly ResourceKey resourceKey_0;

	// Token: 0x04006E45 RID: 28229
	private static readonly ResourceKey resourceKey_1;

	// Token: 0x04006E46 RID: 28230
	private static readonly ResourceKey resourceKey_2;

	// Token: 0x04006E47 RID: 28231
	public static Dictionary<SynchronizableObjectType, ResourceKey> SynchronizableObjectPath;

	// Token: 0x04006E48 RID: 28232
	public static readonly ResourceKey PLAYER_SPIRIT_RESOURCE_KEY;

	// Token: 0x04006E49 RID: 28233
	public const string ControllersBundle = "assets/content/characters/controllers/player_anim_controller.bundle";

	// Token: 0x04006E4A RID: 28234
	public const string FastControllersBundle = "assets/content/characters/controllers/player_anim_controller.animatorcontrollerdata.bundle";

	// Token: 0x04006E4B RID: 28235
	public const string PlayerRootMotionBundle = "assets/content/characters/rootmotiontable/playerrootmotiontable.asset.bundle";

	// Token: 0x04006E4C RID: 28236
	public const string CharacterAnimationsBundle = "assets/content/characters/animations/character_animations.bundle";

	// Token: 0x04006E4D RID: 28237
	public const string SimpleCharacterAnimationsBundle = "assets/content/characters/animations/simple_character_animations.bundle";

	// Token: 0x04006E4E RID: 28238
	public const string SpiritCharacterAnimationsBundle = "assets/content/characters/animations/spirit_character_animations.bundle";

	// Token: 0x04006E4F RID: 28239
	public const string WeaponAnimationsBundle = "/client_assets.bundle";

	// Token: 0x04006E50 RID: 28240
	public const string SimpleWeaponAnimationsBundle = "assets/content/weapons/animations/simple_animations.bundle";

	// Token: 0x04006E51 RID: 28241
	public const string SpiritWeaponAnimationsBundle = "assets/content/weapons/animations/spirit_animations.bundle";

	// Token: 0x04006E52 RID: 28242
	public const string BossKabanControllersBundle = "assets/content/characters/controllers/kaban_anim_controller/kaban_anim_controller.bundle";

	// Token: 0x04006E53 RID: 28243
	public const string KabanRootMotionBundle = "assets/content/characters/rootmotiontable/kabanrootmotiontable.asset.bundle";

	// Token: 0x04006E54 RID: 28244
	private static readonly ResourceKey resourceKey_3;

	// Token: 0x04006E55 RID: 28245
	private static readonly ResourceKey resourceKey_4;

	// Token: 0x04006E56 RID: 28246
	public static readonly ResourceKey PLAYER_FAST_ANIMATOR_CONTROLLER;

	// Token: 0x04006E57 RID: 28247
	public static readonly ResourceKey PLAYER_DEFAULT_ANIMATOR_CONTROLLER_SPIRIT;

	// Token: 0x04006E58 RID: 28248
	public static readonly ResourceKey PLAYER_ANIMATION_CLIPS_KEEPER;

	// Token: 0x04006E59 RID: 28249
	public static readonly ResourceKey PLAYER_ROOTMOTION_TABLE;

	// Token: 0x04006E5A RID: 28250
	public static readonly ResourceKey KABAN_ROOTMOTION_TABLE;

	// Token: 0x04006E5B RID: 28251
	public static readonly ResourceKey BOSS_KABAN_ANIMATOR_CONTROLLER_SPIRIT;

	// Token: 0x04006E5C RID: 28252
	public static readonly ResourceKey BOSS_KABAN_ROOTMOTION_TABLE;

	// Token: 0x04006E5D RID: 28253
	public const string CAMERA_CONTAINER_BUNDLE_NAME = "assets/commonassets/player/cameracontainer.bundle";

	// Token: 0x04006E5E RID: 28254
	public const string USEC_HEAD_BUNDLE_NAME = "assets/content/characters/character/prefabs/usec_head.bundle";

	// Token: 0x04006E5F RID: 28255
	public const string USEC_HEAD_1_BUNDLE_NAME = "assets/content/characters/character/prefabs/usec_head_1.bundle";

	// Token: 0x04006E60 RID: 28256
	public const string USEC_BODY_BUNDLE_NAME = "assets/content/characters/character/prefabs/usec_body.bundle";

	// Token: 0x04006E61 RID: 28257
	public const string USEC_BODY_FEET_NAME = "assets/content/characters/character/prefabs/usec_feet.bundle";

	// Token: 0x04006E62 RID: 28258
	public const string USEC_HANDS_BUNDLE_NAME = "assets/content/hands/usec/usec_hands_skin.bundle";

	// Token: 0x04006E63 RID: 28259
	public const string BEAR_HEAD_0_BUNDLE_NAME = "assets/content/characters/character/prefabs/bear_head.bundle";

	// Token: 0x04006E64 RID: 28260
	public const string BEAR_HEAD_1_BUNDLE_NAME = "assets/content/characters/character/prefabs/bear_head_1.bundle";

	// Token: 0x04006E65 RID: 28261
	public const string BEAR_BODY_BUNDLE_NAME = "assets/content/characters/character/prefabs/bear_body.bundle";

	// Token: 0x04006E66 RID: 28262
	public const string BEAR_FEET_BUNDLE_NAME = "assets/content/characters/character/prefabs/bear_feet.bundle";

	// Token: 0x04006E67 RID: 28263
	public const string BEAR_HANDS_BUNDLE_NAME = "assets/content/hands/bear/bear_hands_skin.bundle";

	// Token: 0x04006E68 RID: 28264
	public const string WILD_HEAD_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_head.bundle";

	// Token: 0x04006E69 RID: 28265
	public const string WILD_BODY_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_body.bundle";

	// Token: 0x04006E6A RID: 28266
	public const string WILD_FEET_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_feet.bundle";

	// Token: 0x04006E6B RID: 28267
	public const string WILD1_HEAD_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_head_1.bundle";

	// Token: 0x04006E6C RID: 28268
	public const string WILD1_BODY_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_body_1.bundle";

	// Token: 0x04006E6D RID: 28269
	public const string WILD1_FEET_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_feet_1.bundle";

	// Token: 0x04006E6E RID: 28270
	public const string WILD2_HEAD_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_head_2.bundle";

	// Token: 0x04006E6F RID: 28271
	public const string WILD2_BODY_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_body_2.bundle";

	// Token: 0x04006E70 RID: 28272
	public const string WILD2_FEET_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_feet_2.bundle";

	// Token: 0x04006E71 RID: 28273
	public const string WILD_DEALMAKER_HEAD = "assets/content/characters/character/prefabs/wild_dealmaker_head.bundle";

	// Token: 0x04006E72 RID: 28274
	public const string WILD_DEALMAKER_BODY = "assets/content/characters/character/prefabs/wild_dealmaker_body.bundle";

	// Token: 0x04006E73 RID: 28275
	public const string WILD_DEALMAKER_FEET = "assets/content/characters/character/prefabs/wild_dealmaker_feet.bundle";

	// Token: 0x04006E74 RID: 28276
	public const string BEAR_TSHIRT_BLACK_HANDS = "assets/content/hands/hands_tshirt_bear_black/hands_tshirt_bear_black.skin.bundle";

	// Token: 0x04006E75 RID: 28277
	public const string BEAR_BLACK_LYNX_HANDS = "assets/content/hands/hand_bear_blacklynx/hand_bear_blacklynx.skin.bundle";

	// Token: 0x04006E76 RID: 28278
	public const string BEAR_GHOSTMARKSMAN_HANDS = "assets/content/hands/hands_bear_ghostmarksman/hands_bear_ghostmarksman.skin.bundle";

	// Token: 0x04006E77 RID: 28279
	public const string BEAR_POLEVOI_HANDS = "assets/content/hands/hands_bear_polevoi/hands_bear_polevoi.skin.bundle";

	// Token: 0x04006E78 RID: 28280
	public const string BEAR_FSB_FAST_RESPONSE_HANDS = "assets/content/hands/hands_bear_fsbfastresponse/hands_bear_fsbfastresponse.skin.bundle";

	// Token: 0x04006E79 RID: 28281
	public const string USEC_AGRESSOR_PARKA_HANDS = "assets/content/hands/hands_usec_aggressor_parka/hands_usec_aggressor_parka.skin.bundle";

	// Token: 0x04006E7A RID: 28282
	public const string USEC_COMBATSHIRT_HANDS = "assets/content/hands/hands_usec_combatshirt/hands_usec_combatshirt.skin.bundle";

	// Token: 0x04006E7B RID: 28283
	public const string USEC_ORC_PCU_HANDS = "assets/content/hands/hands_usec_orc_pcu/hands_usec_orc_pcu.skin.bundle";

	// Token: 0x04006E7C RID: 28284
	public const string USEC_SOFTSHELL_HANDS = "assets/content/hands/hands_usec_softshell/hands_usec_softshell.skin.bundle";

	// Token: 0x04006E7D RID: 28285
	public const string USEC_COMMANDO_HANDS = "assets/content/hands/hands_usec_commando/hands_usec_commando.skin.bundle";

	// Token: 0x04006E7E RID: 28286
	public const string BOSS_KILLA_FEET = "assets/content/characters/character/prefabs/pant_boss_killa.bundle";

	// Token: 0x04006E7F RID: 28287
	public const string BOSS_KILLA_BODY = "assets/content/characters/character/prefabs/top_boss_killa.bundle";

	// Token: 0x04006E80 RID: 28288
	public const string BOSS_KILLA_HEAD = "assets/content/characters/character/prefabs/head_boss_killa.bundle";

	// Token: 0x04006E81 RID: 28289
	public const string SCAV_ELITE_FEET = "assets/content/characters/character/prefabs/pants_wild_scavelite.bundle";

	// Token: 0x04006E82 RID: 28290
	public const string SCAV_ELITE_BODY = "assets/content/characters/character/prefabs/top_wild_scavelite.bundle";

	// Token: 0x04006E83 RID: 28291
	public const string WILD3_BODY_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_body_3.bundle";

	// Token: 0x04006E84 RID: 28292
	public const string WILD3_HEAD_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_head_3.bundle";

	// Token: 0x04006E85 RID: 28293
	public const string WILD_SECURITY1_BODY_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_security_body_1.bundle";

	// Token: 0x04006E86 RID: 28294
	public const string WILD_SECURITY_FEET_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_security_feet_1.bundle";

	// Token: 0x04006E87 RID: 28295
	public const string WILD_SECURITY2_BODY_BUNDLE_NAME = "assets/content/characters/character/prefabs/wild_security_body_2.bundle";

	// Token: 0x04006E88 RID: 28296
	public const string WILD_BODY_FIRSTHANDS_BUNDLE_NAME = "assets/content/hands/wild/wild_body_firsthands.bundle";

	// Token: 0x04006E89 RID: 28297
	public const string WILD_BODY_FIRSTHANDS_1_BUNDLE_NAME = "assets/content/hands/wild/wild_body_1_firsthands.bundle";

	// Token: 0x04006E8A RID: 28298
	public const string WILD_BODY_FIRSTHANDS_2_BUNDLE_NAME = "assets/content/hands/wild/wild_body_2_firsthands.bundle";

	// Token: 0x04006E8B RID: 28299
	public const string WILD_BODY_FIRSTHANDS_3_BUNDLE_NAME = "assets/content/hands/wild/wild_body_3_firsthands.bundle";

	// Token: 0x04006E8C RID: 28300
	public const string WEAPON_EMPTY_HANDS_BUNDLE_NAME = "assets/content/weapons/empty hands/weapon_empty_hands_container.bundle";

	// Token: 0x04006E8D RID: 28301
	public const string AUDIO_SHOT_BUNDLE_NAME = "assets/content/audio/audioshot.bundle";

	// Token: 0x04006E8E RID: 28302
	public const string PLAYER_MOVEMENT_SOUNDS_BUNDLE = "assets/content/audio/prefabs/movement/sounds.bundle";

	// Token: 0x04006E8F RID: 28303
	public const string PLAYER_WEAPON_SOUNDS_BUNDLE = "assets/content/audio/prefabs/shells/weaponsounds.bundle";

	// Token: 0x04006E90 RID: 28304
	public const string ITEM_DROP_SOUNDS_BUNDLE = "assets/content/audio/prefabs/items/itemdropsounds.bundle";

	// Token: 0x04006E91 RID: 28305
	public const string AIRDROP_LANDING_SOUNDS_BUNDLE = "assets/content/audio/prefabs/airdrop/airdropsounds.bundle";

	// Token: 0x04006E92 RID: 28306
	public const string item_equipment_backpack = "assets/content/items/equipment/backpack/item_equipment_backpack.bundle";

	// Token: 0x04006E93 RID: 28307
	public const string item_equipment_usec_vest = "assets/content/items/equipment/usec_vest/item_equipment_usec_vest.bundle";

	// Token: 0x04006E94 RID: 28308
	public const string weapon_colt_m4a1_556x45_container = "assets/content/weapons/m4a1/weapon_colt_m4a1_556x45_container.bundle";

	// Token: 0x04006E95 RID: 28309
	public const string PATRON_RSP_GREEN = "assets/content/items/ammo/patrons/patron_rsp_green.bundle";

	// Token: 0x04006E96 RID: 28310
	public const string PATRON_RSP_RED = "assets/content/items/ammo/patrons/patron_rsp_red.bundle";

	// Token: 0x04006E97 RID: 28311
	public const string PATRON_RSP_YELLOW = "assets/content/items/ammo/patrons/patron_rsp_yellow.bundle";

	// Token: 0x04006E98 RID: 28312
	public const string PATRON_RSP_WHITE = "assets/content/items/ammo/patrons/patron_rsp_white.bundle";

	// Token: 0x04006E99 RID: 28313
	public const string PHRASES = "assets/content/audio/phrases/allphrases.bundle";

	// Token: 0x04006E9A RID: 28314
	public const string ITEM_SOUNDS = "assets/content/audio/itemsounds/itemsounds.bundle";

	// Token: 0x04006E9B RID: 28315
	public const string BEAR_1 = "assets/content/audio/phrases/bear_1_voice.bundle";

	// Token: 0x04006E9C RID: 28316
	public const string BEAR_1_ENG = "assets/content/audio/phrases/bear_1_eng_voice.bundle";

	// Token: 0x04006E9D RID: 28317
	public const string BEAR_2 = "assets/content/audio/phrases/bear_2_voice.bundle";

	// Token: 0x04006E9E RID: 28318
	public const string BEAR_2_ENG = "assets/content/audio/phrases/bear_2_eng_voice.bundle";

	// Token: 0x04006E9F RID: 28319
	public const string BEAR_3 = "assets/content/audio/phrases/bear_3_voice.bundle";

	// Token: 0x04006EA0 RID: 28320
	public const string USEC_1 = "assets/content/audio/phrases/usec_1_voice.bundle";

	// Token: 0x04006EA1 RID: 28321
	public const string USEC_2 = "assets/content/audio/phrases/usec_2_voice.bundle";

	// Token: 0x04006EA2 RID: 28322
	public const string USEC_3 = "assets/content/audio/phrases/usec_3_voice.bundle";

	// Token: 0x04006EA3 RID: 28323
	public const string USEC_4 = "assets/content/audio/phrases/usec_4_voice.bundle";

	// Token: 0x04006EA4 RID: 28324
	public const string USEC_5 = "assets/content/audio/phrases/usec_5_voice.bundle";

	// Token: 0x04006EA5 RID: 28325
	public const string SCAV_1 = "assets/content/audio/phrases/scav_1_voice.bundle";

	// Token: 0x04006EA6 RID: 28326
	public const string SCAV_2 = "assets/content/audio/phrases/scav_2_voice.bundle";

	// Token: 0x04006EA7 RID: 28327
	public const string SCAV_3 = "assets/content/audio/phrases/scav_3_voice.bundle";

	// Token: 0x04006EA8 RID: 28328
	public const string SCAV_4 = "assets/content/audio/phrases/scav_4_voice.bundle";

	// Token: 0x04006EA9 RID: 28329
	public const string SCAV_5 = "assets/content/audio/phrases/scav_5_voice.bundle";

	// Token: 0x04006EAA RID: 28330
	public const string SCAV_6 = "assets/content/audio/phrases/scav_6_voice.bundle";

	// Token: 0x04006EAB RID: 28331
	public const string BOSSSANITAR = "assets/content/audio/phrases/bosssanitar_voice.bundle";

	// Token: 0x04006EAC RID: 28332
	public const string BOSSBULLY = "assets/content/audio/phrases/bossbully_voice.bundle";

	// Token: 0x04006EAD RID: 28333
	public const string BOSSGLUHAR = "assets/content/audio/phrases/bossgluhar_voice.bundle";

	// Token: 0x04006EAE RID: 28334
	public const string BOSSPRIEST = "assets/content/audio/phrases/sectantpriest.bundle";

	// Token: 0x04006EAF RID: 28335
	public const string BOSSWARRIOR = "assets/content/audio/phrases/sectantwarrior_voice.bundle";

	// Token: 0x04006EB0 RID: 28336
	public const string BOSS_BIG_PIPE = "assets/content/audio/phrases/bossbigpipe_voice.bundle";

	// Token: 0x04006EB1 RID: 28337
	public const string BOSS_BIRD_EYE = "assets/content/audio/phrases/bossbirdeye_voice.bundle";

	// Token: 0x04006EB2 RID: 28338
	public const string BOSS_KNIGHT = "assets/content/audio/phrases/bossknight_voice.bundle";

	// Token: 0x04006EB3 RID: 28339
	public const string BOSS_KILLA = "assets/content/audio/phrases/bosskilla_voice.bundle";

	// Token: 0x04006EB4 RID: 28340
	public const string BOSS_TAGILLA = "assets/content/audio/phrases/bosstagilla_voice.bundle";

	// Token: 0x04006EB5 RID: 28341
	public const string ARENA_GUARD_1 = "assets/content/audio/phrases/arena_guard_1_voice.bundle";

	// Token: 0x04006EB6 RID: 28342
	public const string ARENA_GUARD_2 = "assets/content/audio/phrases/arena_guard_2_voice.bundle";

	// Token: 0x04006EB7 RID: 28343
	public const string BOSS_KABAN = "assets/content/audio/phrases/boss_kaban_voice.bundle";

	// Token: 0x04006EB8 RID: 28344
	public const string BOSS_KOLLONTAY = "assets/content/audio/phrases/boss_kollontay_voice.bundle";

	// Token: 0x04006EB9 RID: 28345
	public const string BOSS_STURMAN = "assets/content/audio/phrases/boss_sturman_voice.bundle";

	// Token: 0x04006EBA RID: 28346
	private static readonly Dictionary<string, string> dictionary_0;

	// Token: 0x04006EBB RID: 28347
	public static readonly string[] ADDITIONAL_BUNDLES_TO_PRELOAD;

	// Token: 0x04006EBC RID: 28348
	public static readonly string[] BUNDLES_TO_PRELOAD;
}
