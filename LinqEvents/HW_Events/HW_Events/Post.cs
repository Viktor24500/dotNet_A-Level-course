using HW_Events.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events
{
    public class Post<T> where T : IItems
    {
        public EventHandler<T> LetterNotify;
        public EventHandler<T> BoxNotify;

        public void Notification(T item) 
        {
            if (item.Type.Equals(Types.Letter))
            {
                LetterNotify?.Invoke(this, item);
            }
            else if (item.Type.Equals(Types.Box))
            {
                BoxNotify?.Invoke(this, item);
            }
            else 
            {
                throw new ArgumentException();
            }
        }
    }
}
