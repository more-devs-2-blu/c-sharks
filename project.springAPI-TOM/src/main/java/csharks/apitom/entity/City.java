package csharks.apitom.entity;

import jakarta.persistence.*;
import lombok.Data;

import java.io.Serializable;
import java.util.UUID;

@Data
@Entity
@Table(name = "city")
public class City implements Serializable {
  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private UUID Id;
  @Column(name = "name")
  private String name;
  @Column(name = "tom")
  private String tom;
}
