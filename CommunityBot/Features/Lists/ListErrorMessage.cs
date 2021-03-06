﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityBot.Features.Lists
{
    public static class ListErrorMessage
    {
        public static readonly string ListDoesNotExist_list = "List '{0}' does not exist.";
        public static readonly string ListAlreadyExists_list = "List '{0}' already exists.";
        public static readonly string ListIsEmpty_list = "The list '{0}' is empty";
        public static readonly string NoLists = "There are no lists";
        public static readonly string WrongFormat = "Wrong format";
        public static readonly string UnknownCommand_command = "Unknown command '{0}'.";
        public static readonly string UnknownError = "Oops, something went wrong";
    }
}
