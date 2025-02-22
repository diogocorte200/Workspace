﻿using AutoMapper;
using Stefanini.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Stefanini.Domain
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pedido, PedidoDto>();
            CreateMap<ItensPedido, ItensPedidosDto>();
            //CreateMap<PedidoDto, Pedido>();
            //CreateMap<ItensPedidoDto, ItensPedido>();
        }
    }
}
