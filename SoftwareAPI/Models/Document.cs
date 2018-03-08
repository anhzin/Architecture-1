using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ImplementationClasses;

namespace SoftwareAPI.Models
{
    public class Document : ImplementationActorProp
    {
        [ReadOnly(true)]
        [UIHint("readonly")]
        [DisplayName("Document Number")]
        public int Number { get; set; }

        [ReadOnly(true)]
        [UIHint("readonly")]
        [DisplayName("Document Owner ID")]
        public Guid ActorID { get => base.ActorID; set => base.ActorID = value; }

        [ReadOnly(true)]
        [UIHint("readonly")]
        [DisplayName("Document ID")]
        public Guid ActorPropID { get => base.ActorPropID; set => base.ActorPropID = value; }

        [DisplayName("Document Title")]
        [StringLength(250, MinimumLength = 3)]
        [Required(ErrorMessage = "Can't be empty or less than 3 characters")]
        public string ActorPropTitle { get => base.ActorPropTitle; set => base.ActorPropTitle = value; }


    }

}