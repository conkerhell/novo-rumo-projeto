﻿
using NovoRumoProjeto.Utilities;
using NovoRumoProjeto.Utilities.Validation;
using Resources;
using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.IO;
using System.Web;

namespace NovoRumoProjeto.Areas.Admin.Models
{
    public class DailyViewModel
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(ErrorMessageResourceType = typeof(LocalizedMessages),
            ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Nome")]
        public string displayFileName { get; set; }

        [Required(ErrorMessageResourceType = typeof(LocalizedMessages),
            ErrorMessageResourceName = "FileRequired")]
        [FileTypes("jpg", "jpeg", "png", ErrorMessageResourceType = typeof(LocalizedMessages),
            ErrorMessageResourceName = "FileFormatInvalid")]
        public HttpPostedFileBase file { get; set; }

        [Required(ErrorMessageResourceType = typeof(LocalizedMessages),
            ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Required(ErrorMessageResourceType = typeof(LocalizedMessages),
            ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessageResourceType = typeof(LocalizedMessages),
            ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        public bool SaveFile()
        {
            var status = false;
            var fileName = Path.GetFileName(file.FileName);
            var filePath = Path.Combine(HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings[Consts.DAILY_IMAGE_PATH]), fileName);

            if (!string.IsNullOrWhiteSpace(filePath))
            {
                file.SaveAs(filePath);
                displayFileName = file.FileName;
                status = true;
            }
            return status;
        }
    }
}