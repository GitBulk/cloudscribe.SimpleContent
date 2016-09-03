﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:                  Joe Audette
// Created:                 2016-02-07
// Last Modified:           2016-09-03
// 

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace cloudscribe.SimpleContent.Models
{
    
    public interface IPostQueries
    {
        
        //Task<List<Post>> GetAllPosts(
        //    string blogId,
        //    CancellationToken cancellationToken);

        Task<Dictionary<string, int>> GetCategories(
            string blogId,
            bool includeUnpublished,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<Dictionary<string, int>> GetArchives(
            string blogId,
            bool includeUnpublished,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<Post> GetPost(
            string blogId,
            string postId,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<PostResult> GetPostBySlug(
            string blogId,
            string slug,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<bool> SlugIsAvailable(
            string blogId,
            string slug,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<List<Post>> GetRecentPosts(
            string blogId,
            int numberToGet,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<List<Post>> GetPosts(
            string blogId,
            bool includeUnpublished,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<PagedResult<Post>> GetPosts(
            string blogId,
            string category,
            bool includeUnpublished,
            int pageNumber,
            int pageSize,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<PagedResult<Post>> GetPosts(
            string blogId,
            int year,
            int month = 0,
            int day = 0,
            int pageNumber = 1,
            int pageSize = 10,
            bool includeUnpublished = false,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<int> GetCount(
            string blogId,
            string category,
            bool includeUnpublished,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        Task<int> GetCount(
            string blogId,
            int year,
            int month = 0,
            int day = 0,
            bool includeUnpublished = false,
            CancellationToken cancellationToken = default(CancellationToken)
            );

        
    }
}
