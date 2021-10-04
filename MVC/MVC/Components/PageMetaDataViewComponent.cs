﻿using CMS.DocumentEngine;
using Generic.Models;
using Generic.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MVC.RepositoryLibrary.Interfaces;
using System.Threading.Tasks;

namespace Generic.Components
{
    [ViewComponent(Name = "PageMetaData")]
    public class PageMetaDataViewComponent : ViewComponent
    {
        public PageMetaDataViewComponent(IMetaDataRepository metaDataRepository)
        {
            MetaDataRepository = metaDataRepository;
        }

        public IMetaDataRepository MetaDataRepository { get; }

        /// <summary>
        /// Uses the current page context to render meta data
        /// </summary>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var metaData = await MetaDataRepository.GetMetaDataAsync();
            PageMetaDataViewModel model = new PageMetaDataViewModel()
            {
                Title = metaData.Title,
                Keywords = metaData.Keywords,
                Description = metaData.Description,
                Thumbnail = metaData.Thumbnail
            };
            return View("~/Views/Shared/Components/PageMetaData/Default.cshtml", model);
        }
    }
}
