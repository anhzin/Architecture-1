using ImplementationClasses;
using System;
using System.ComponentModel;

namespace SoftwareAPI.Models
{
    public class Document : ImplementationActorProp
    {
        public int Number { get; set; }

        public Guid ActorID { get => base.ActorID; set => base.ActorID = value; }

        [DisplayName("Document ID")]
        public Guid ActorPropID { get => base.ActorPropID; set => base.ActorPropID = value; }

        public string ActorPropTitle { get => base.ActorPropTitle; set => base.ActorPropTitle = value; }


    }

}