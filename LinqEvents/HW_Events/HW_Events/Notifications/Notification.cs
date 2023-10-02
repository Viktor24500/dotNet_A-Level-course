using HW_Events.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events.Notifications
{
    public class Notification
    {
        public Post<IItems> Post;
        public string Name;

        public Notification(Post<IItems> post, string name)
        {
            Post = post;
            Name = name;
        }

        public virtual void NotifyItem(IItems item)
        {
            //Post.Notification += (sender, e) => Console.WriteLine($"{item.Name} get {item.Description}");
        }
    }
}
