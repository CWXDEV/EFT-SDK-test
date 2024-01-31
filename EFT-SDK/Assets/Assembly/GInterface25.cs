using System;
using EFT;

// Token: 0x020006E3 RID: 1763
public interface GInterface25
{
	// Token: 0x14000079 RID: 121
	// (add) Token: 0x06002968 RID: 10600
	// (remove) Token: 0x06002969 RID: 10601
	event Action<bool> OnSprintStateChangedEvent;

	// Token: 0x1400007A RID: 122
	// (add) Token: 0x0600296A RID: 10602
	// (remove) Token: 0x0600296B RID: 10603
	event Action WeightRelatedValuesUpdated;

	// Token: 0x1700072C RID: 1836
	// (get) Token: 0x0600296C RID: 10604
	bool Exhausted { get; }

	// Token: 0x1700072D RID: 1837
	// (get) Token: 0x0600296D RID: 10605
	bool CanSprint { get; }

	// Token: 0x1700072E RID: 1838
	// (get) Token: 0x0600296E RID: 10606
	bool Sprinting { get; }

	// Token: 0x1700072F RID: 1839
	// (get) Token: 0x0600296F RID: 10607
	bool HoldingBreath { get; }

	// Token: 0x17000730 RID: 1840
	// (get) Token: 0x06002970 RID: 10608
	float CarryingWeightModifier { get; }

	// Token: 0x17000731 RID: 1841
	// (get) Token: 0x06002971 RID: 10609
	float SprintAcceleration { get; }

	// Token: 0x17000732 RID: 1842
	// (get) Token: 0x06002972 RID: 10610
	float SprintSpeed { get; }

	// Token: 0x17000733 RID: 1843
	// (get) Token: 0x06002973 RID: 10611
	float SprintSensitivity { get; }

	// Token: 0x17000734 RID: 1844
	// (get) Token: 0x06002974 RID: 10612
	bool CanJump { get; }

	// Token: 0x17000735 RID: 1845
	// (get) Token: 0x06002975 RID: 10613
	bool CanMeleeHit { get; }

	// Token: 0x17000736 RID: 1846
	// (get) Token: 0x06002976 RID: 10614
	BackendConfigSettingsClass.GClass1365 StaminaParameters { get; }

	// Token: 0x17000737 RID: 1847
	// (set) Token: 0x06002977 RID: 10615
	bool BerserkRestorationFactor { set; }

	// Token: 0x06002978 RID: 10616
	void Init(Player player);

	// Token: 0x06002979 RID: 10617
	void StandUp();

	// Token: 0x0600297A RID: 10618
	void UpdatePose(int i);

	// Token: 0x0600297B RID: 10619
	void UpdateWeightLimits();

	// Token: 0x0600297C RID: 10620
	void OnWeightUpdated();

	// Token: 0x0600297D RID: 10621
	void Sprint(bool target);

	// Token: 0x0600297E RID: 10622
	void Aim(float mass = 0f);

	// Token: 0x0600297F RID: 10623
	void HoldBreath(bool enable);

	// Token: 0x06002980 RID: 10624
	void Update(float dt);

	// Token: 0x06002981 RID: 10625
	void LateUpdate();

	// Token: 0x06002982 RID: 10626
	void OnBreach();

	// Token: 0x06002983 RID: 10627
	void InvokeInsufficient();

	// Token: 0x06002984 RID: 10628
	void OnThrow(bool lowThrow);

	// Token: 0x06002985 RID: 10629
	void ConsumeAsMelee(float expense);

	// Token: 0x06002986 RID: 10630
	void OnJump(bool enabled);

	// Token: 0x06002987 RID: 10631
	void BulletHit(float staminaBurnRate);
}
