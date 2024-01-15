﻿using Proiect1.BLL.DTOs;
using Proiect1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.BLL.Interfaces;

public interface IFriendshipRepository
{
    void AddFriendship(Friendship friendship);
    List<FriendshipGetDTO> GetFriendshipsToList();
    void DeleteFriendship(Friendship friendship);
    Friendship GetFriendshipById(int id);
}
