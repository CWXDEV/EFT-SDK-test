using System;
using EFT.HealthSystem;

// Token: 0x020021BE RID: 8638
public interface IEffect
{
	// Token: 0x17001DAE RID: 7598
	// (get) Token: 0x0600B14F RID: 45391
	Type Type { get; }

	// Token: 0x17001DAF RID: 7599
	// (get) Token: 0x0600B150 RID: 45392
	EBodyPart BodyPart { get; }

	// Token: 0x17001DB0 RID: 7600
	// (get) Token: 0x0600B151 RID: 45393
	EEffectState State { get; }

	// Token: 0x17001DB1 RID: 7601
	// (get) Token: 0x0600B152 RID: 45394
	float CurStateTimeLeft { get; }

	// Token: 0x17001DB2 RID: 7602
	// (get) Token: 0x0600B153 RID: 45395
	float WorkStateTime { get; }

	// Token: 0x17001DB3 RID: 7603
	// (get) Token: 0x0600B154 RID: 45396
	float WholeTime { get; }

	// Token: 0x17001DB4 RID: 7604
	// (get) Token: 0x0600B155 RID: 45397
	float CurrentStrength { get; }

	// Token: 0x17001DB5 RID: 7605
	// (get) Token: 0x0600B156 RID: 45398
	float Strength { get; }

	// Token: 0x17001DB6 RID: 7606
	// (get) Token: 0x0600B157 RID: 45399
	float TimeLeft { get; }

	// Token: 0x17001DB7 RID: 7607
	// (get) Token: 0x0600B158 RID: 45400
	bool Critical { get; }

	// Token: 0x17001DB8 RID: 7608
	// (get) Token: 0x0600B159 RID: 45401
	GClass2457[] DisplayableVariations { get; }

	// Token: 0x0600B15A RID: 45402
	void AddWholeTime(float deltaTime);

	// Token: 0x17001DB9 RID: 7609
	// (get) Token: 0x0600B15B RID: 45403
	float OverallDuration { get; }

	// Token: 0x17001DBA RID: 7610
	// (get) Token: 0x0600B15C RID: 45404
	bool Existing { get; }

	// Token: 0x17001DBB RID: 7611
	// (get) Token: 0x0600B15D RID: 45405
	bool Active { get; }

	// Token: 0x17001DBC RID: 7612
	// (get) Token: 0x0600B15E RID: 45406
	bool Residual { get; }

	// Token: 0x0600B15F RID: 45407
	void Propagate();

	// Token: 0x17001DBD RID: 7613
	// (get) Token: 0x0600B160 RID: 45408
	bool WasPaused { get; }
}
