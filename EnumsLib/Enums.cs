﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsLib
{
    public enum OpenMode
    {
        Add,
        AddByCopy,
        Edit,
        NewUserForGroup,
        NewGroupForUser,
        NewTestForUser,
        NewTestForGroup,
        SelectTest,
        SelectUser
    }
    public enum FormSelector 
    { 
        Active, 
        Archived, 
        All, 
        ByGroup, 
        ByUser, 
        ByTest, 
        ByUserAndTest, 
        None 
    }

    public enum TcpPackType
    {
        ClientAuthDataPack,
        ClientFormClosePack,
        ClientTestFormClosePack,
        ClientUserTestsRequestPack,
        ClientUserCompletedTestPack,
        ClientConnectionStatusPack,
        ServerAuthAnswerPack,
        ServerUserTestsPack,
        ServerConnectionStatusAnswerPack,
        ServerStopOrClosePack
    }
}