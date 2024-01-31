using System;
using System.Threading.Tasks;
using ChatShared;
using Comfort.Common;

// Token: 0x02001815 RID: 6165
public interface GInterface146
{
	// Token: 0x17001478 RID: 5240
	// (get) Token: 0x0600847B RID: 33915
	GClass1839 SocialNetwork { get; }

	// Token: 0x17001479 RID: 5241
	// (get) Token: 0x0600847C RID: 33916
	ChatServerClass[] ChatServers { get; }

	// Token: 0x0600847D RID: 33917
	void ChatGetDialogList(int limit, int offset, Callback<GClass930[]> callback);

	// Token: 0x0600847E RID: 33918
	void ChatCreateGroupDialog(string chatName, string[] groupMembers, Callback callback);

	// Token: 0x0600847F RID: 33919
	void ChatSendMessage(string id, int type, string text, string replyTo, Callback<string> callback);

	// Token: 0x06008480 RID: 33920
	void ChatDeleteMessage(string dialogId, string messageId, Callback<string> callback);

	// Token: 0x06008481 RID: 33921
	Task<bool> ChatDeleteAllMessages(string dialogId);

	// Token: 0x06008482 RID: 33922
	Task<bool> DeleteDialog(string dialogId);

	// Token: 0x06008483 RID: 33923
	void ChatGetDialogMessages(string id, int type, int limit, double time, Callback<GClass932> callback);

	// Token: 0x06008484 RID: 33924
	void PinDialog(string dialogId, Callback callback);

	// Token: 0x06008485 RID: 33925
	void UnpinDialog(string dialogId, Callback callback);

	// Token: 0x06008486 RID: 33926
	void AllAttachmentsFromDialog(string dialogId, Callback<GClass932> callback);

	// Token: 0x06008487 RID: 33927
	void GetDialogInformation(string dialogId, Callback<GClass930> callback);

	// Token: 0x06008488 RID: 33928
	Task<bool> RedeemProfileRewards(GStruct72[] rewards);

	// Token: 0x06008489 RID: 33929
	void MutePlayer(string uid, Callback callback);

	// Token: 0x0600848A RID: 33930
	void UnmutePlayer(string uid, Callback callback);

	// Token: 0x0600848B RID: 33931
	void InviteToDialogue(string dialogId, string[] uid, Callback callback);

	// Token: 0x0600848C RID: 33932
	void RemoveFromDialogue(string dialogId, string uid, Callback callback);

	// Token: 0x0600848D RID: 33933
	void LeaveChatDialogue(string dialogId, Callback callback);

	// Token: 0x0600848E RID: 33934
	void ChatReadDialogues(string[] dialogs, Callback callback);

	// Token: 0x0600848F RID: 33935
	void FindAccountByNickname(string nickname, Callback<UpdatableChatMember[]> callback);

	// Token: 0x06008490 RID: 33936
	void GetFriendsList(Callback<GClass926> callback);

	// Token: 0x06008491 RID: 33937
	void RemoveFromFriendsList(string id, Callback callback);

	// Token: 0x06008492 RID: 33938
	void GetInputFriendsRequests(Callback<GClass927[]> callback);

	// Token: 0x06008493 RID: 33939
	void GetOutputFriendsRequests(Callback<GClass927[]> callback);

	// Token: 0x06008494 RID: 33940
	void SendFriendRequest(string id, Callback<GClass3172> callback);

	// Token: 0x06008495 RID: 33941
	Task<bool> CancelFriendRequest(string profileId);

	// Token: 0x06008496 RID: 33942
	void AcceptFriendRequest(string profileId, Callback callback);

	// Token: 0x06008497 RID: 33943
	Task AcceptAllFriendRequests();

	// Token: 0x06008498 RID: 33944
	void DeclineFriendRequest(string profileId, Callback callback);

	// Token: 0x06008499 RID: 33945
	void TransferChatLeadership(string dialogId, string uid, Callback callback);

	// Token: 0x0600849A RID: 33946
	void GetChatServers(string versionId, Callback<ChatServerClass[]> callback);

	// Token: 0x0600849B RID: 33947
	void GetOtherPlayerProfile(string accountId, Callback<GClass1208> callback);
}
