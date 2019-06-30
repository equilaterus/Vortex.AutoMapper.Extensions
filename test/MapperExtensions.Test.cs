using AutoMapper;
using Equilaterus.Vortex;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Equilaterus.Vortex.AutoMapper.Extensions.Test
{
    public class MapperExtensions
    {
        [Fact]
        public void MaybeMap_Success()
        {
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map<double>(1))
                .Returns(1.2);

            var objectMock = mapperMock.Object;
            var result = objectMock.MaybeMap<double>(1);

            Assert.IsType<Maybe<double>>(result);
            Assert.Equal(1.2, result.Match(x => x, 0));
        }

        [Fact]
        public void MaybeMap_Null_ThrowsException()
        {
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map<object>(null))
                .Returns(null);

            var objectMock = mapperMock.Object;           

            Assert.Throws<ArgumentNullException>(() => objectMock.MaybeMap<object>(null));
        }

        [Fact]
        public void MaybeMap_SourceDestination_Success()
        {
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map("1", 0.2))
                .Returns(1.2);

            var objectMock = mapperMock.Object;
            var result = objectMock.MaybeMap("1", 0.2);

            Assert.IsType<Maybe<double>>(result);
            Assert.Equal(1.2, result.Match(x => x, 0));
        }

        [Fact]
        public void MaybeMap_SourceDestination_Null_ThrowsException()
        {
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map<object, object>(null, null))
                .Returns(null);

            var objectMock = mapperMock.Object;

            Assert.Throws<ArgumentNullException>(() => objectMock.MaybeMap<object, object>(null, null));
        }
    }
}
