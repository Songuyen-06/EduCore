﻿using EduCore.BackEnd.Application.Abstractions.Services;
using EduCore.BackEnd.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EduCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : Controller
    {
        public ICommentService commentService;
        public CommentController(ICommentService _commentService)
        {
            commentService = _commentService;
        }
        [HttpPost("addComment")]
        public async Task<IActionResult> AddComment([FromBody] AddedCommentDTO commentDTO)
        {
            await commentService.AddComment(commentDTO);
            return Ok();
        }
        [HttpGet("getCommentById/{commentId}")]
        public async Task<IActionResult> GetCommentById(int commentId)
        {
           
            return Ok(await commentService.GetCommentById(commentId));
        }

    }


}
