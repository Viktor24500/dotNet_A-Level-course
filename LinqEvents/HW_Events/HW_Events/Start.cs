using HW_Events.Entity;
using HW_Events.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events
{
    public class Start
    {
        public static void StartMethod() 
        {
            Post<IItems> post = new Post<IItems>();

            List<IItems> items = new List<IItems>()
            {
                new Box("box1", "GMC"),
                new Box("box1", "Ford"),
                new Letter("letter1", "Smith"),
                new Letter("letter2", "Smith")
            };

            List<Notification> notifications = new List<Notification>()
            {
                new LettterNotification(post, "Colt"),
                new BoxNotification(post, "Colt"),
            };

            notifications[0].NotifyItem(items[1]);
            notifications[1].NotifyItem(items[2]);
            notifications[0].NotifyItem(items[3]);
            notifications[1].NotifyItem(items[0]);
            post.Notification(items[3]);
        }
    }
}