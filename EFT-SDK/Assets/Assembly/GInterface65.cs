using System;
using System.Collections.Generic;
using GPUInstancer;
using UnityEngine;

// Token: 0x02000E94 RID: 3732
public interface GInterface65
{
	// Token: 0x06004DAB RID: 19883
	Shader GetInstancedShader(List<ShaderInstance> shaderInstances, string shaderName);

	// Token: 0x06004DAC RID: 19884
	Material GetInstancedMaterial(List<ShaderInstance> shaderInstances, Material originalMaterial);

	// Token: 0x06004DAD RID: 19885
	bool ClearEmptyShaderInstances(List<ShaderInstance> shaderInstances);

	// Token: 0x06004DAE RID: 19886
	bool IsShadersInstancedVersionExists(List<ShaderInstance> shaderInstances, string shaderName);

	// Token: 0x06004DAF RID: 19887
	string GetExtensionCode();
}
