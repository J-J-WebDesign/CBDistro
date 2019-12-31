import React from 'react';
import "./HomeBanner.css"
import Carousel from "react-bootstrap/Carousel"

const HomeBanner = (props) => {
  const goToProducts =()=>{
    props.goToProducts()
  }
    return (
<Carousel controls="true">
  <Carousel.Item>
    <img
      className="d-block w-100"
      src="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fhome.bt.com%2Fimages%2Fwhat-is-cbd-oil-the-cannabis-based-supplement-that-experts-say-can-treat-anxiety-and-joint-pain-136426786016502601-180501101010.jpg&f=1&nofb=1"
      alt="Third slide"
      onClick={goToProducts}
    />

    <Carousel.Caption>
      <h1 className="captionText">Click for our products!</h1>
      <p className="subCaptionText">We have great deals for any budget.</p>
    </Carousel.Caption>
  </Carousel.Item>
  <Carousel.Item>
    <img
      className="d-block w-100"
      src="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fdutchseedsshop.com%2Fwp-content%2Fuploads%2F2017%2F11%2FCBD-Oil.jpg&f=1&nofb=1"
      alt="First slide"
    />
    <Carousel.Caption>
      <h1 className="captionText">Second slide label</h1>
      <p className="subCaptionText">Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
    </Carousel.Caption>
  </Carousel.Item>
  <Carousel.Item>
    <img
      className="d-block w-100"
      src="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fg.foolcdn.com%2Feditorial%2Fimages%2F527577%2Fcbd-oils-cannabis-leaves-and-chalkboard.jpg&f=1&nofb=1"
      alt="Third slide"
    />

    <Carousel.Caption>
      <h1 className="captionText">Third slide label</h1>
      <p className="subCaptionText">Praesent commodo cursus magna, vel scelerisque nisl consectetur.</p>
    </Carousel.Caption>
  </Carousel.Item>
</Carousel>
    );
};

export default HomeBanner;