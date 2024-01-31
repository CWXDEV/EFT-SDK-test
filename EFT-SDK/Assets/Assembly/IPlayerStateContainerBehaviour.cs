using System;
using EFT;

// Token: 0x02000733 RID: 1843
public interface IPlayerStateContainerBehaviour : IStateBehaviour
{
	// Token: 0x17000791 RID: 1937
	// (get) Token: 0x06002B51 RID: 11089
	// (set) Token: 0x06002B52 RID: 11090
	bool DefaultState { get; set; }

	// Token: 0x17000792 RID: 1938
	// (get) Token: 0x06002B53 RID: 11091
	// (set) Token: 0x06002B54 RID: 11092
	EPlayerState PlayerStateName { get; set; }

	// Token: 0x17000793 RID: 1939
	// (get) Token: 0x06002B55 RID: 11093
	// (set) Token: 0x06002B56 RID: 11094
	BaseMovementState EncapsulatedState { get; set; }

	// Token: 0x17000794 RID: 1940
	// (get) Token: 0x06002B57 RID: 11095
	int FullNameHash { get; }

	// Token: 0x06002B58 RID: 11096
	void Init(Func<EPlayerState, int, bool, BaseMovementState> newStateFunc);

	// Token: 0x06002B59 RID: 11097
	void Deinit();
}
