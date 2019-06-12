using AutoMapper;
using Equilaterus.Vortex;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Vortex.AutoMapper.Extensions.Test
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
            mapperMock.Setup(x => x.Map<object>(It.IsAny<object>()))
                .Returns(null);

            var objectMock = mapperMock.Object;           

            Assert.Throws<ArgumentNullException>(() => objectMock.MaybeMap<object>(new object()));
        }
               

        [Fact]
        public void MaybeMap_SourceDestination_Null_ThrowsException()
        {
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map(It.IsAny<object>(), It.IsAny<object>()))
                .Returns(null);

            var objectMock = mapperMock.Object;

            Assert.Throws<ArgumentNullException>(() => objectMock.MaybeMap(new object(), new object()));
        }
    }
}
