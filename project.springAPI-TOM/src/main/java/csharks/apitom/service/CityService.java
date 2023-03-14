package csharks.apitom.service;

import csharks.apitom.entity.City;
import csharks.apitom.repository.CityRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class CityService {
  @Autowired
  CityRepository cityRepository;

  public Boolean saveCity(List<City> cities) {
    cityRepository.saveAll(cities);
    return true;
  }

  public City findCityByName(String name) {
    return cityRepository.findByName(name);
  }
}
