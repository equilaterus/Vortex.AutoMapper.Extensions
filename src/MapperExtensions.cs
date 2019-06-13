using AutoMapper;
using Equilaterus.Vortex;
using System;
using System.Collections.Generic;
using System.Text;

namespace Equilaterus.Vortex.AutoMapper.Extensions
{
    public static class MapperExtensions
    {
        public static Maybe<TDestination> MaybeMap<TDestination>(
            this IMapper mapper, object source)
        {
            return new Maybe<TDestination>(mapper.Map<TDestination>(source));
        }

        public static Maybe<TDestination> MaybeMap<TSource, TDestination>(
            this IMapper mapper, TSource source, TDestination destination)
        {
            return new Maybe<TDestination>(mapper.Map(source, destination));
        }
    }
}
