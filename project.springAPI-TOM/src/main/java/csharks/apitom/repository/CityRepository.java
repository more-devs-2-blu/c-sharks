package csharks.apitom.repository;

import csharks.apitom.entity.City;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.UUID;

public interface CityRepository extends JpaRepository<City, UUID> {
  City findByName(String Name);
}
