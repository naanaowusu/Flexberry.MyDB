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
    /// Class meeting.
    /// </summary>
    // *** Start programmer edit section *** (ClassMeeting CustomAttributes)

    // *** End programmer edit section *** (ClassMeeting CustomAttributes)
    [AutoAltered()]
    [Caption("Class meeting")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ClassMeetingE", new string[] {
            "MeetingDate as \'Meeting date\'"})]
    [AssociatedDetailViewAttribute("ClassMeetingE", "Presntation", "PresntationE", true, "", "Presntation", true, new string[] {
            ""})]
    [View("ClassMeetingL", new string[] {
            "MeetingDate as \'Meeting date\'"})]
    public class ClassMeeting : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fMeetingDate;
        
        private IIS.MyDB.DetailArrayOfPresntation fPresntation;
        
        // *** Start programmer edit section *** (ClassMeeting CustomMembers)

        // *** End programmer edit section *** (ClassMeeting CustomMembers)

        
        /// <summary>
        /// MeetingDate.
        /// </summary>
        // *** Start programmer edit section *** (ClassMeeting.MeetingDate CustomAttributes)

        // *** End programmer edit section *** (ClassMeeting.MeetingDate CustomAttributes)
        public virtual System.DateTime MeetingDate
        {
            get
            {
                // *** Start programmer edit section *** (ClassMeeting.MeetingDate Get start)

                // *** End programmer edit section *** (ClassMeeting.MeetingDate Get start)
                System.DateTime result = this.fMeetingDate;
                // *** Start programmer edit section *** (ClassMeeting.MeetingDate Get end)

                // *** End programmer edit section *** (ClassMeeting.MeetingDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ClassMeeting.MeetingDate Set start)

                // *** End programmer edit section *** (ClassMeeting.MeetingDate Set start)
                this.fMeetingDate = value;
                // *** Start programmer edit section *** (ClassMeeting.MeetingDate Set end)

                // *** End programmer edit section *** (ClassMeeting.MeetingDate Set end)
            }
        }
        
        /// <summary>
        /// Class meeting.
        /// </summary>
        // *** Start programmer edit section *** (ClassMeeting.Presntation CustomAttributes)

        // *** End programmer edit section *** (ClassMeeting.Presntation CustomAttributes)
        public virtual IIS.MyDB.DetailArrayOfPresntation Presntation
        {
            get
            {
                // *** Start programmer edit section *** (ClassMeeting.Presntation Get start)

                // *** End programmer edit section *** (ClassMeeting.Presntation Get start)
                if ((this.fPresntation == null))
                {
                    this.fPresntation = new IIS.MyDB.DetailArrayOfPresntation(this);
                }
                IIS.MyDB.DetailArrayOfPresntation result = this.fPresntation;
                // *** Start programmer edit section *** (ClassMeeting.Presntation Get end)

                // *** End programmer edit section *** (ClassMeeting.Presntation Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ClassMeeting.Presntation Set start)

                // *** End programmer edit section *** (ClassMeeting.Presntation Set start)
                this.fPresntation = value;
                // *** Start programmer edit section *** (ClassMeeting.Presntation Set end)

                // *** End programmer edit section *** (ClassMeeting.Presntation Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ClassMeetingE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ClassMeetingE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ClassMeetingE", typeof(IIS.MyDB.ClassMeeting));
                }
            }
            
            /// <summary>
            /// "ClassMeetingL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ClassMeetingL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ClassMeetingL", typeof(IIS.MyDB.ClassMeeting));
                }
            }
        }
    }
}
