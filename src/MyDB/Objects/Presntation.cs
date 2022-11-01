﻿//------------------------------------------------------------------------------
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
    /// Presntation.
    /// </summary>
    // *** Start programmer edit section *** (Presntation CustomAttributes)

    // *** End programmer edit section *** (Presntation CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("PresntationE", new string[] {
            "BookScore as \'Book score\'",
            "PresentationURL as \'Presentation URL\'",
            "VideoURL as \'Video URL\'",
            "BookReview as \'Book review\'",
            "Book as \'Book\'",
            "Book.Name as \'Name\'",
            "Speaker as \'Speaker\'",
            "Speaker.FirstName as \'First name\'"}, Hidden=new string[] {
            "Book.Name",
            "Speaker.FirstName"})]
    [MasterViewDefineAttribute("PresntationE", "Book", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [MasterViewDefineAttribute("PresntationE", "Speaker", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "FirstName")]
    public class Presntation : ICSSoft.STORMNET.DataObject
    {
        
        private int fBookScore;
        
        private string fPresentationURL;
        
        private string fVideoURL;
        
        private string fBookReview;
        
        private IIS.MyDB.Book fBook;
        
        private IIS.MyDB.Speaker fSpeaker;
        
        private IIS.MyDB.ClassMeeting fClassMeeting;
        
        // *** Start programmer edit section *** (Presntation CustomMembers)

        // *** End programmer edit section *** (Presntation CustomMembers)

        
        /// <summary>
        /// BookReview.
        /// </summary>
        // *** Start programmer edit section *** (Presntation.BookReview CustomAttributes)

        // *** End programmer edit section *** (Presntation.BookReview CustomAttributes)
        [StrLen(255)]
        public virtual string BookReview
        {
            get
            {
                // *** Start programmer edit section *** (Presntation.BookReview Get start)

                // *** End programmer edit section *** (Presntation.BookReview Get start)
                string result = this.fBookReview;
                // *** Start programmer edit section *** (Presntation.BookReview Get end)

                // *** End programmer edit section *** (Presntation.BookReview Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Presntation.BookReview Set start)

                // *** End programmer edit section *** (Presntation.BookReview Set start)
                this.fBookReview = value;
                // *** Start programmer edit section *** (Presntation.BookReview Set end)

                // *** End programmer edit section *** (Presntation.BookReview Set end)
            }
        }
        
        /// <summary>
        /// BookScore.
        /// </summary>
        // *** Start programmer edit section *** (Presntation.BookScore CustomAttributes)

        // *** End programmer edit section *** (Presntation.BookScore CustomAttributes)
        public virtual int BookScore
        {
            get
            {
                // *** Start programmer edit section *** (Presntation.BookScore Get start)

                // *** End programmer edit section *** (Presntation.BookScore Get start)
                int result = this.fBookScore;
                // *** Start programmer edit section *** (Presntation.BookScore Get end)

                // *** End programmer edit section *** (Presntation.BookScore Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Presntation.BookScore Set start)

                // *** End programmer edit section *** (Presntation.BookScore Set start)
                this.fBookScore = value;
                // *** Start programmer edit section *** (Presntation.BookScore Set end)

                // *** End programmer edit section *** (Presntation.BookScore Set end)
            }
        }
        
        /// <summary>
        /// PresentationURL.
        /// </summary>
        // *** Start programmer edit section *** (Presntation.PresentationURL CustomAttributes)

        // *** End programmer edit section *** (Presntation.PresentationURL CustomAttributes)
        [StrLen(255)]
        public virtual string PresentationURL
        {
            get
            {
                // *** Start programmer edit section *** (Presntation.PresentationURL Get start)

                // *** End programmer edit section *** (Presntation.PresentationURL Get start)
                string result = this.fPresentationURL;
                // *** Start programmer edit section *** (Presntation.PresentationURL Get end)

                // *** End programmer edit section *** (Presntation.PresentationURL Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Presntation.PresentationURL Set start)

                // *** End programmer edit section *** (Presntation.PresentationURL Set start)
                this.fPresentationURL = value;
                // *** Start programmer edit section *** (Presntation.PresentationURL Set end)

                // *** End programmer edit section *** (Presntation.PresentationURL Set end)
            }
        }
        
        /// <summary>
        /// VideoURL.
        /// </summary>
        // *** Start programmer edit section *** (Presntation.VideoURL CustomAttributes)

        // *** End programmer edit section *** (Presntation.VideoURL CustomAttributes)
        [StrLen(255)]
        public virtual string VideoURL
        {
            get
            {
                // *** Start programmer edit section *** (Presntation.VideoURL Get start)

                // *** End programmer edit section *** (Presntation.VideoURL Get start)
                string result = this.fVideoURL;
                // *** Start programmer edit section *** (Presntation.VideoURL Get end)

                // *** End programmer edit section *** (Presntation.VideoURL Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Presntation.VideoURL Set start)

                // *** End programmer edit section *** (Presntation.VideoURL Set start)
                this.fVideoURL = value;
                // *** Start programmer edit section *** (Presntation.VideoURL Set end)

                // *** End programmer edit section *** (Presntation.VideoURL Set end)
            }
        }
        
        /// <summary>
        /// Presntation.
        /// </summary>
        // *** Start programmer edit section *** (Presntation.Book CustomAttributes)

        // *** End programmer edit section *** (Presntation.Book CustomAttributes)
        [NotNull()]
        public virtual IIS.MyDB.Book Book
        {
            get
            {
                // *** Start programmer edit section *** (Presntation.Book Get start)

                // *** End programmer edit section *** (Presntation.Book Get start)
                IIS.MyDB.Book result = this.fBook;
                // *** Start programmer edit section *** (Presntation.Book Get end)

                // *** End programmer edit section *** (Presntation.Book Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Presntation.Book Set start)

                // *** End programmer edit section *** (Presntation.Book Set start)
                this.fBook = value;
                // *** Start programmer edit section *** (Presntation.Book Set end)

                // *** End programmer edit section *** (Presntation.Book Set end)
            }
        }
        
        /// <summary>
        /// Presntation.
        /// </summary>
        // *** Start programmer edit section *** (Presntation.Speaker CustomAttributes)

        // *** End programmer edit section *** (Presntation.Speaker CustomAttributes)
        [NotNull()]
        public virtual IIS.MyDB.Speaker Speaker
        {
            get
            {
                // *** Start programmer edit section *** (Presntation.Speaker Get start)

                // *** End programmer edit section *** (Presntation.Speaker Get start)
                IIS.MyDB.Speaker result = this.fSpeaker;
                // *** Start programmer edit section *** (Presntation.Speaker Get end)

                // *** End programmer edit section *** (Presntation.Speaker Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Presntation.Speaker Set start)

                // *** End programmer edit section *** (Presntation.Speaker Set start)
                this.fSpeaker = value;
                // *** Start programmer edit section *** (Presntation.Speaker Set end)

                // *** End programmer edit section *** (Presntation.Speaker Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.MyDB.ClassMeeting.
        /// </summary>
        // *** Start programmer edit section *** (Presntation.ClassMeeting CustomAttributes)

        // *** End programmer edit section *** (Presntation.ClassMeeting CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual IIS.MyDB.ClassMeeting ClassMeeting
        {
            get
            {
                // *** Start programmer edit section *** (Presntation.ClassMeeting Get start)

                // *** End programmer edit section *** (Presntation.ClassMeeting Get start)
                IIS.MyDB.ClassMeeting result = this.fClassMeeting;
                // *** Start programmer edit section *** (Presntation.ClassMeeting Get end)

                // *** End programmer edit section *** (Presntation.ClassMeeting Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Presntation.ClassMeeting Set start)

                // *** End programmer edit section *** (Presntation.ClassMeeting Set start)
                this.fClassMeeting = value;
                // *** Start programmer edit section *** (Presntation.ClassMeeting Set end)

                // *** End programmer edit section *** (Presntation.ClassMeeting Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "PresntationE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View PresntationE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("PresntationE", typeof(IIS.MyDB.Presntation));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Presntation.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfPresntation CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfPresntation CustomAttributes)
    public class DetailArrayOfPresntation : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.MyDB.DetailArrayOfPresntation members)

        // *** End programmer edit section *** (IIS.MyDB.DetailArrayOfPresntation members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Presntation by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Presntation.
        /// </summary>
        public DetailArrayOfPresntation(IIS.MyDB.ClassMeeting fClassMeeting) : 
                base(typeof(Presntation), ((ICSSoft.STORMNET.DataObject)(fClassMeeting)))
        {
        }
        
        public IIS.MyDB.Presntation this[int index]
        {
            get
            {
                return ((IIS.MyDB.Presntation)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.MyDB.Presntation dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
