using System;
using EFT.Vehicle;

// Token: 0x0200064F RID: 1615
public interface GInterface22
{
	// Token: 0x170006A1 RID: 1697
	// (get) Token: 0x060024F9 RID: 9465
	// (set) Token: 0x060024FA RID: 9466
	PathConfig CurrentPathConfig { get; set; }

	// Token: 0x170006A2 RID: 1698
	// (get) Token: 0x060024FB RID: 9467
	// (set) Token: 0x060024FC RID: 9468
	MoveByPathType MoveByPathType { get; set; }

	// Token: 0x060024FD RID: 9469
	void Initialization(MapPathConfig mapPathsConfig);

	// Token: 0x060024FE RID: 9470
	void SpawnInPoint(int index);

	// Token: 0x060024FF RID: 9471
	void MoveEnable();

	// Token: 0x06002500 RID: 9472
	void MoveDisable();

	// Token: 0x06002501 RID: 9473
	void MoveToDestination(string destinationID);

	// Token: 0x06002502 RID: 9474
	void MovePauseOn(float pauseDuration);

	// Token: 0x06002503 RID: 9475
	void MovePauseOff();

	// Token: 0x06002504 RID: 9476
	void MoveProcess();

	// Token: 0x06002505 RID: 9477
	void PauseProcess();

	// Token: 0x06002506 RID: 9478
	void Reset();
}
