using HW_Events.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events.Notifications
{
    public class LettterNotification : Notification
    {
        public LettterNotification(Post<IItems> post, string name) : base(post, name)
        {
        }

        public override void NotifyItem(IItems item)
        {
            Post.LetterNotify += (sender, e) => Console.WriteLine($"{item.Name} get {item.Description}");
        }
    }
}
