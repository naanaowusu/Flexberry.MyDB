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
    /// Speaker.
    /// </summary>
    // *** Start programmer edit section *** (Speaker CustomAttributes)

    // *** End programmer edit section *** (Speaker CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("SpeakerE", new string[] {
            "FirstName as \'First name\'",
            "LastName as \'Last name\'"})]
    [View("SpeakerL", new string[] {
            "FirstName as \'First name\'",
            "LastName as \'Last name\'"})]
    public class Speaker : ICSSoft.STORMNET.DataObject
    {
        
        private string fFirstName;
        
        private string fLastName;
        
        // *** Start programmer edit section *** (Speaker CustomMembers)

        // *** End programmer edit section *** (Speaker CustomMembers)

        
        /// <summary>
        /// FirstName.
        /// </summary>
        // *** Start programmer edit section *** (Speaker.FirstName CustomAttributes)

        // *** End programmer edit section *** (Speaker.FirstName CustomAttributes)
        [StrLen(255)]
        public virtual string FirstName
        {
            get
            {
                // *** Start programmer edit section *** (Speaker.FirstName Get start)

                // *** End programmer edit section *** (Speaker.FirstName Get start)
                string result = this.fFirstName;
                // *** Start programmer edit section *** (Speaker.FirstName Get end)

                // *** End programmer edit section *** (Speaker.FirstName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Speaker.FirstName Set start)

                // *** End programmer edit section *** (Speaker.FirstName Set start)
                this.fFirstName = value;
                // *** Start programmer edit section *** (Speaker.FirstName Set end)

                // *** End programmer edit section *** (Speaker.FirstName Set end)
            }
        }
        
        /// <summary>
        /// LastName.
        /// </summary>
        // *** Start programmer edit section *** (Speaker.LastName CustomAttributes)

        // *** End programmer edit section *** (Speaker.LastName CustomAttributes)
        [StrLen(255)]
        public virtual string LastName
        {
            get
            {
                // *** Start programmer edit section *** (Speaker.LastName Get start)

                // *** End programmer edit section *** (Speaker.LastName Get start)
                string result = this.fLastName;
                // *** Start programmer edit section *** (Speaker.LastName Get end)

                // *** End programmer edit section *** (Speaker.LastName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Speaker.LastName Set start)

                // *** End programmer edit section *** (Speaker.LastName Set start)
                this.fLastName = value;
                // *** Start programmer edit section *** (Speaker.LastName Set end)

                // *** End programmer edit section *** (Speaker.LastName Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "SpeakerE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SpeakerE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SpeakerE", typeof(IIS.MyDB.Speaker));
                }
            }
            
            /// <summary>
            /// "SpeakerL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SpeakerL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SpeakerL", typeof(IIS.MyDB.Speaker));
                }
            }
        }
    }
}
