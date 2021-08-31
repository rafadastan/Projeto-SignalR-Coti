using AutoMapper;
using Projeto02.Application.Models.Contas;
using Projeto02.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Application.Mappings
{
    public class DtoToModelMap : Profile
    {
        public DtoToModelMap()
        {
            CreateMap<ContaCategoriaDTO, GetContasCategoriaModel>()
                .AfterMap(
                    (src, dest) =>
                    {
                        dest.Categoria = src.Categoria.ToString();
                    }
                );
        }
    }
}
