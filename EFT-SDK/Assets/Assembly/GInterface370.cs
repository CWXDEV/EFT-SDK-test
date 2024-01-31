using System;

// Token: 0x02002C3D RID: 11325
public interface GInterface370<T> where T : struct
{
	// Token: 0x0600DF2B RID: 57131
	void UpdateValue(T value, bool sendCallback = true, T? min = null, T? max = null);

	// Token: 0x0600DF2C RID: 57132
	void Bind(Action<T> valueChanged);

	// Token: 0x0600DF2D RID: 57133
	T CurrentValue();
}
