using System;
using UnityEngine;

// Token: 0x0200073F RID: 1855
public interface ICharacterController
{
	// Token: 0x170007AC RID: 1964
	// (get) Token: 0x06002BB3 RID: 11187
	// (set) Token: 0x06002BB4 RID: 11188
	bool isEnabled { get; set; }

	// Token: 0x170007AD RID: 1965
	// (get) Token: 0x06002BB5 RID: 11189
	// (set) Token: 0x06002BB6 RID: 11190
	Vector3 center { get; set; }

	// Token: 0x170007AE RID: 1966
	// (get) Token: 0x06002BB7 RID: 11191
	CollisionFlags collisionFlags { get; }

	// Token: 0x170007AF RID: 1967
	// (get) Token: 0x06002BB8 RID: 11192
	// (set) Token: 0x06002BB9 RID: 11193
	bool detectCollisions { get; set; }

	// Token: 0x170007B0 RID: 1968
	// (get) Token: 0x06002BBA RID: 11194
	// (set) Token: 0x06002BBB RID: 11195
	float height { get; set; }

	// Token: 0x170007B1 RID: 1969
	// (get) Token: 0x06002BBC RID: 11196
	bool isGrounded { get; }

	// Token: 0x170007B2 RID: 1970
	// (get) Token: 0x06002BBD RID: 11197
	// (set) Token: 0x06002BBE RID: 11198
	float skinWidth { get; set; }

	// Token: 0x170007B3 RID: 1971
	// (get) Token: 0x06002BBF RID: 11199
	// (set) Token: 0x06002BC0 RID: 11200
	float radius { get; set; }

	// Token: 0x170007B4 RID: 1972
	// (get) Token: 0x06002BC1 RID: 11201
	// (set) Token: 0x06002BC2 RID: 11202
	float slopeLimit { get; set; }

	// Token: 0x170007B5 RID: 1973
	// (get) Token: 0x06002BC3 RID: 11203
	// (set) Token: 0x06002BC4 RID: 11204
	float stepOffset { get; set; }

	// Token: 0x170007B6 RID: 1974
	// (get) Token: 0x06002BC5 RID: 11205
	Vector3 velocity { get; }

	// Token: 0x170007B7 RID: 1975
	// (get) Token: 0x06002BC6 RID: 11206
	Rigidbody attachedRigidbody { get; }

	// Token: 0x170007B8 RID: 1976
	// (get) Token: 0x06002BC7 RID: 11207
	Bounds bounds { get; }

	// Token: 0x170007B9 RID: 1977
	// (get) Token: 0x06002BC8 RID: 11208
	// (set) Token: 0x06002BC9 RID: 11209
	float contactOffset { get; set; }

	// Token: 0x06002BCA RID: 11210
	CollisionFlags Move(Vector3 motion, float deltaTime);

	// Token: 0x06002BCB RID: 11211
	bool SimpleMove(Vector3 motion);

	// Token: 0x06002BCC RID: 11212
	void CopyFields(ICharacterController characterController);

	// Token: 0x06002BCD RID: 11213
	void CopyFields(GStruct201 footprint);

	// Token: 0x06002BCE RID: 11214
	GStruct201 GetFootprint();

	// Token: 0x06002BCF RID: 11215
	Collider GetCollider();

	// Token: 0x170007BA RID: 1978
	// (get) Token: 0x06002BD0 RID: 11216
	bool ShouldStickToGround { get; }

	// Token: 0x170007BB RID: 1979
	// (get) Token: 0x06002BD1 RID: 11217
	bool SupportDepenetration { get; }

	// Token: 0x06002BD2 RID: 11218
	void SetSteerDirection(Vector3 steerDirection);

	// Token: 0x170007BC RID: 1980
	// (get) Token: 0x06002BD3 RID: 11219
	// (set) Token: 0x06002BD4 RID: 11220
	float SpeedLimit { get; set; }

	// Token: 0x170007BD RID: 1981
	// (get) Token: 0x06002BD5 RID: 11221
	// (set) Token: 0x06002BD6 RID: 11222
	bool IsSpeedLimitWasEnabledAtTheFrame { get; set; }

	// Token: 0x1400008E RID: 142
	// (add) Token: 0x06002BD7 RID: 11223
	// (remove) Token: 0x06002BD8 RID: 11224
	event Action<float> OnHeightChanged;

	// Token: 0x06002BD9 RID: 11225
	void SetEnableVerticalDepenetration(bool enable);
}
