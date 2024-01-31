using System;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003188 RID: 12680
	public abstract class PathGenerator : MonoBehaviour
	{
		// Token: 0x0600F9EB RID: 63979
		public abstract void Generator(Vector3[] path, float thickness, bool closed);

		// Token: 0x0600F9EC RID: 63980
		public abstract void Clear();
	}
}
