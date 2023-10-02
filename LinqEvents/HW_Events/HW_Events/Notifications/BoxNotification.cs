using HW_Events.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events.Notifications
{
    public class BoxNotification : Notification
    {
        public BoxNotification(Post<IItems> post, string name) : base(post, name)
        {
        }

        public override void NotifyItem(IItems item)
        {
            Post.BoxNotify += (sender, e) => Console.WriteLine($"{item.Name} get {item.Description}");
        }
    }
}
