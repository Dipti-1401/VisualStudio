﻿using System;
using GitHub.Api;
using GitHub.Models;
using GitHub.Primitives;
using GitHub.Services;
using LibGit2Sharp;
using Microsoft.VisualStudio.Text;
using NSubstitute;
using Octokit;

internal static class Args
{
    public static bool Boolean { get { return Arg.Any<bool>(); } }
    public static int Int32 { get { return Arg.Any<int>(); } }
    public static string String { get { return Arg.Any<string>(); } }
    public static Span Span { get { return Arg.Any<Span>(); } }
    public static SnapshotPoint SnapshotPoint { get { return Arg.Any<SnapshotPoint>(); } }
    public static NewRepository NewRepository { get { return Arg.Any<NewRepository>(); } }
    public static IAccount Account { get { return Arg.Any<IAccount>(); } }
    public static IApiClient ApiClient { get { return Arg.Any<IApiClient>(); } }
    public static IServiceProvider ServiceProvider { get { return Arg.Any<IServiceProvider>(); } }
    public static IAvatarProvider AvatarProvider { get { return Arg.Any<IAvatarProvider>(); } }
    public static HostAddress HostAddress { get { return Arg.Any<HostAddress>(); } } 
    public static Uri Uri { get { return Arg.Any<Uri>(); } }
    public static LibGit2Sharp.Branch Branch { get { return Arg.Any<LibGit2Sharp.Branch>(); } }
    public static Remote Remote { get { return Arg.Any<Remote>(); } }
}
