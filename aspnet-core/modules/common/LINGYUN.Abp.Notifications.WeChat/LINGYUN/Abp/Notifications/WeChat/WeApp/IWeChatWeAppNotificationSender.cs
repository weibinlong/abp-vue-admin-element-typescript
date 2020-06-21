﻿using System.Threading.Tasks;

namespace LINGYUN.Abp.Notifications.WeChat.WeApp
{
    public interface IWeChatWeAppNotificationSender
    {
        Task SendAsync(WeChatWeAppSendNotificationData notificationData);
    }
}
