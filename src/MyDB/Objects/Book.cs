//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.MyDB
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Book.
    /// </summary>
    // *** Start programmer edit section *** (Book CustomAttributes)

    // *** End programmer edit section *** (Book CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("BookE", new string[] {
            "Name as \'Name\'",
            "Author as \'Author\'",
            "PagesCount as \'Pages count\'",
            "CoverURL as \'Cover URL\'",
            "DescriptionURL as \'Description URL\'",
            "Tags as \'Tags\'"})]
    [View("BookL", new string[] {
            "Name as \'Name\'",
            "Author as \'Author\'",
            "PagesCount as \'Pages count\'",
            "CoverURL as \'Cover URL\'",
            "DescriptionURL as \'Description URL\'",
            "Tags as \'Tags\'"})]
    public class Book : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private string fAuthor;
        
        private int fPagesCount;
        
        private string fCoverURL;
        
        private string fDescriptionURL;
        
        private string fTags;
        
        // *** Start programmer edit section *** (Book CustomMembers)

        // *** End programmer edit section *** (Book CustomMembers)

        
        /// <summary>
        /// Author.
        /// </summary>
        // *** Start programmer edit section *** (Book.Author CustomAttributes)

        // *** End programmer edit section *** (Book.Author CustomAttributes)
        [StrLen(255)]
        public virtual string Author
        {
            get
            {
                // *** Start programmer edit section *** (Book.Author Get start)

                // *** End programmer edit section *** (Book.Author Get start)
                string result = this.fAuthor;
                // *** Start programmer edit section *** (Book.Author Get end)

                // *** End programmer edit section *** (Book.Author Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Book.Author Set start)

                // *** End programmer edit section *** (Book.Author Set start)
                this.fAuthor = value;
                // *** Start programmer edit section *** (Book.Author Set end)

                // *** End programmer edit section *** (Book.Author Set end)
            }
        }
        
        /// <summary>
        /// CoverURL.
        /// </summary>
        // *** Start programmer edit section *** (Book.CoverURL CustomAttributes)

        // *** End programmer edit section *** (Book.CoverURL CustomAttributes)
        [StrLen(255)]
        public virtual string CoverURL
        {
            get
            {
                // *** Start programmer edit section *** (Book.CoverURL Get start)

                // *** End programmer edit section *** (Book.CoverURL Get start)
                string result = this.fCoverURL;
                // *** Start programmer edit section *** (Book.CoverURL Get end)

                // *** End programmer edit section *** (Book.CoverURL Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Book.CoverURL Set start)

                // *** End programmer edit section *** (Book.CoverURL Set start)
                this.fCoverURL = value;
                // *** Start programmer edit section *** (Book.CoverURL Set end)

                // *** End programmer edit section *** (Book.CoverURL Set end)
            }
        }
        
        /// <summary>
        /// DescriptionURL.
        /// </summary>
        // *** Start programmer edit section *** (Book.DescriptionURL CustomAttributes)

        // *** End programmer edit section *** (Book.DescriptionURL CustomAttributes)
        [StrLen(255)]
        public virtual string DescriptionURL
        {
            get
            {
                // *** Start programmer edit section *** (Book.DescriptionURL Get start)

                // *** End programmer edit section *** (Book.DescriptionURL Get start)
                string result = this.fDescriptionURL;
                // *** Start programmer edit section *** (Book.DescriptionURL Get end)

                // *** End programmer edit section *** (Book.DescriptionURL Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Book.DescriptionURL Set start)

                // *** End programmer edit section *** (Book.DescriptionURL Set start)
                this.fDescriptionURL = value;
                // *** Start programmer edit section *** (Book.DescriptionURL Set end)

                // *** End programmer edit section *** (Book.DescriptionURL Set end)
            }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Book.Name CustomAttributes)

        // *** End programmer edit section *** (Book.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Book.Name Get start)

                // *** End programmer edit section *** (Book.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Book.Name Get end)

                // *** End programmer edit section *** (Book.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Book.Name Set start)

                // *** End programmer edit section *** (Book.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Book.Name Set end)

                // *** End programmer edit section *** (Book.Name Set end)
            }
        }
        
        /// <summary>
        /// PagesCount.
        /// </summary>
        // *** Start programmer edit section *** (Book.PagesCount CustomAttributes)

        // *** End programmer edit section *** (Book.PagesCount CustomAttributes)
        public virtual int PagesCount
        {
            get
            {
                // *** Start programmer edit section *** (Book.PagesCount Get start)

                // *** End programmer edit section *** (Book.PagesCount Get start)
                int result = this.fPagesCount;
                // *** Start programmer edit section *** (Book.PagesCount Get end)

                // *** End programmer edit section *** (Book.PagesCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Book.PagesCount Set start)

                // *** End programmer edit section *** (Book.PagesCount Set start)
                this.fPagesCount = value;
                // *** Start programmer edit section *** (Book.PagesCount Set end)

                // *** End programmer edit section *** (Book.PagesCount Set end)
            }
        }
        
        /// <summary>
        /// Tags.
        /// </summary>
        // *** Start programmer edit section *** (Book.Tags CustomAttributes)

        // *** End programmer edit section *** (Book.Tags CustomAttributes)
        [StrLen(255)]
        public virtual string Tags
        {
            get
            {
                // *** Start programmer edit section *** (Book.Tags Get start)

                // *** End programmer edit section *** (Book.Tags Get start)
                string result = this.fTags;
                // *** Start programmer edit section *** (Book.Tags Get end)

                // *** End programmer edit section *** (Book.Tags Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Book.Tags Set start)

                // *** End programmer edit section *** (Book.Tags Set start)
                this.fTags = value;
                // *** Start programmer edit section *** (Book.Tags Set end)

                // *** End programmer edit section *** (Book.Tags Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "BookE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View BookE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("BookE", typeof(IIS.MyDB.Book));
                }
            }
            
            /// <summary>
            /// "BookL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View BookL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("BookL", typeof(IIS.MyDB.Book));
                }
            }
        }
    }
}
