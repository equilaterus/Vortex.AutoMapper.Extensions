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
            // Prepare
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map<double>(1))
                .Returns(1.2);

            // Execute
            var result = mapperMock.Object.MaybeMap<double>(1);

            // Verify
            Assert.IsType<Maybe<double>>(result);
            Assert.Equal(1.2, result.Match(x => x, 0));
        }

        [Fact]
        public void MaybeMap_Null_ThrowsException()
        {
            // Prepare
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map<object>(null))
                .Returns(null);

            // Execute
            Assert.Throws<ArgumentNullException>(() => mapperMock.Object.MaybeMap<object>(null));
        }

        [Fact]
        public void MaybeMap_SourceDestination_Success()
        {
            // Prepare
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map("1", 0.2))
                .Returns(1.2);

            // Execute
            var result = mapperMock.Object.MaybeMap("1", 0.2);

            // Verify
            Assert.IsType<Maybe<double>>(result);
            Assert.Equal(1.2, result.Match(x => x, 0));
        }

        [Fact]
        public void MaybeMap_SourceDestination_Null_ThrowsException()
        {
            // Prepare
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map<object, object>(null, null))
                .Returns(null);
            
            // Execute
            Assert.Throws<ArgumentNullException>(() => mapperMock.Object.MaybeMap<object, object>(null, null));
        }
    }
}
