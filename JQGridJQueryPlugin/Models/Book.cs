using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQGridJQueryPlugin.Models
{
    public class Book
    {
        private short bookId;

        public short BookId
        {
            get { return bookId; }
            //set { bookId = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string summary;

        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }
        private short pageNumber;

        public short PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private bool isContinued;

        public bool IsContinued
        {
            get { return isContinued; }
            set { isContinued = value; }
        }
        private byte cateId;

        public byte CateId
        {
            get { return cateId; }
            set { cateId = value; }
        }

        public Book(short bookId, string name, string summary, short pageNumber, string author, bool isContinued, byte cateId)
        {
            this.bookId = bookId;
            this.name = name;
            this.summary = summary;
            this.pageNumber = pageNumber;
            this.author = author;
            this.isContinued = isContinued;
            this.cateId = cateId;
        }
    }
}