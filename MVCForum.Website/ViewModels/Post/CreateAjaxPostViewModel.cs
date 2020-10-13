namespace MvcForum.Web.ViewModels.Post
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Core.Constants;
    using MvcForum.Web.Application;

    public class CreateAjaxPostViewModel
    {
        [UIHint(Constants.EditorType)]
        [AllowHtml]
        //[StringLength(6000)]
        [Required(ErrorMessage = "The Content field is required")]
        public string PostContent { get; set; }

        public Guid Topic { get; set; }
        public bool DisablePosting { get; set; }
        public Guid? InReplyTo { get; set; }
        public string ReplyToUsername { get; set; }
    }
}