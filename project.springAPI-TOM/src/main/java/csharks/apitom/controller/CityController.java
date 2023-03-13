package csharks.apitom.controller;

import csharks.apitom.entity.City;
import csharks.apitom.service.CityService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping(value = "/city")
public class CityController {
  @Autowired
  CityService cityService;

  @GetMapping(value = "/{name}")
  public ResponseEntity<String> getTOMCode(@PathVariable String name) {
    City city = cityService.findCityByName(name);
    return ResponseEntity.ok().body(city.getTom());
  }

  @PostMapping
  public ResponseEntity<City> saveCity(@RequestBody City city) {
    City newCity = cityService.saveCity(city);
    return ResponseEntity.ok().body(newCity);
  }
}
