﻿using System;
using System.Collections.Generic;
using NovoRumoProjeto.DAL.About;
using NovoRumoProjeto.Utilities.Extensions;
using NovoRumoProjeto.Utilities;

namespace NovoRumoProjeto.Models
{
    public class AboutViewModel
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string displayFilename { get; set; }

        public DateTime? Data { get; set; }

        public List<AboutViewModel> Get()
        {
            IAboutDAL aboutDAL = new AboutDAL();
            var model = new List<AboutViewModel>();
            var entity = aboutDAL.GetNewestAbout();

            foreach (var item in entity)
            {
                var About = new AboutViewModel();

                About.Title = item.Title;
                About.Description = item.Description;
                About.displayFilename = item.fileName.GetImagePath(Consts.ABOUT_IMAGE_PATH);
                About.Data = item.Data;
                About.ID = item.AboutID;
                model.Add(About);
            }
            return (model);
        }
    }
}