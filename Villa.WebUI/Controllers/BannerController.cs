﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.BannerDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
    public class BannerController : Controller
    {

        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;
        public BannerController(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _bannerService.TGetListAsync();
            var bannerlist = _mapper.Map<List<ResultBannerDto>>(values);
            return View(bannerlist);
        }

        public async Task<IActionResult> DeleteBanner(ObjectId id)
        {
            await _bannerService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        public IActionResult CreateBanner()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto createBannerDto)
        {
            var newBanner = _mapper.Map<Banner>(createBannerDto);
            await _bannerService.TCreateAsync(newBanner);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateBanner(ObjectId id)
        {
            var value = await _bannerService.TGetByIdAsync(id);
            var updateBanner = _mapper.Map<UpdateBannerDto>(value);
            return View(updateBanner);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBannerDto)
        {
            var banner = _mapper.Map<Banner>(updateBannerDto);
            await _bannerService.TUpdateAsync(banner);
            return RedirectToAction("Index");
        }

    }
}
