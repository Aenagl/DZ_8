using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS
{
    internal class Song
    {
        #region Fields
        /// <summary>
        ///название
        /// </summary>
        public string name;
        /// <summary>
        /// автор
        /// </summary>
        public string author;
        /// <summary>
        /// предыдущая
        /// </summary>
        public Song previous;
        #endregion

        #region Quality
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public Song Previous
        {
            get { return previous; }
            set { previous = value; }
        }
        #endregion

        #region Method

        public string Title()
        {
            return $"{Name},автор: {Author}";
        }
        public override bool Equals(object o)
        {
            if (o is Song newsong)
            {
                return (this.Name == newsong.Name && this.Author == newsong.Author);
            }
            return false;
            #endregion
        }
        #region Constructors
        public Song()
        { 
        }
        public Song(string name, string author) 
        { 
            Name = name;
            Author = author;
            Previous = null;
        }
        public Song(string name,string author, Song previous)
        {
            Name = name;
            Author = author;
            Previous = previous;
        }
        #endregion
    }
}