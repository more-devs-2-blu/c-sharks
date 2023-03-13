package csharks.apitom.service;

import csharks.apitom.entity.City;
import csharks.apitom.repository.CityRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CityService {
  @Autowired
  CityRepository cityRepository;

  public City saveCity(City city) {
    return cityRepository.save(city);
  }

  public City findCityByName(String name) {
    return cityRepository.findByName(name);
  }
}
