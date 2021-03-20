﻿using AutoMapper;
using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Server.Helpers
{
    public class AutoMapperPerfiles : Profile
    {
        public AutoMapperPerfiles()
        {
            CreateMap<Persona, Persona>()
                .ForMember(x => x.Foto, option => option.Ignore());
        }
    }
}
