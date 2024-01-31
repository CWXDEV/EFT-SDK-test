using System;
using EFT.UI;

// Token: 0x02002AA4 RID: 10916
public interface GInterface365
{
	// Token: 0x0600D908 RID: 55560
	BaseNotificationView CreateNotificationView<TNotification>(TNotification notification) where TNotification : NotificationClass;

	// Token: 0x0600D909 RID: 55561
	BaseNotificationView CreateDefaultView(NotificationClass notification);
}
