# Архитектура

  Добавить / удалить животное - AnimalsController.cs, InMemoryAnimalRepository.cs
  
  Добавить / удалить вольер - EnclosuresController.cs, InMemoryEnclosureRepository.cs
  
  Переместить животное между вольерами - AnimalTransferService.cs
  
  Просмотреть расписание кормлений - FeedingController.cs, InMemoryFeedingScheduleRepository.cs
  
  Добавить новое кормление - FeedingController.cs, FeedingOrganizationService.cs
  
  Просмотреть статистику зоопарка - ZooStatisticsService.cs

## Проект строго разделён на 4 слоя:

  Domain — содержит бизнес-сущности (Animal, Enclosure, FeedingSchedule) и value-объекты (AnimalStatus, EnclosureType)

  Application — реализует бизнес-сервисы: перемещение, кормление, сбор статистики. Все зависимости оформлены через интерфейсы (IAnimalRepository, и т.д.)

  Infrastructure — реализация in-memory хранилищ

  Presentation — REST API контроллеры

## Принципы соблюдены:

  Все зависимости направлены внутрь

  Слой Domain ни от кого не зависит

  Зависимости между слоями только через интерфейсы

  Вся бизнес-логика инкапсулирована в Domain и Application

## Применены основные принципы DDD:

  Использованы Value Objects вместо строк/enum — AnimalStatus, EnclosureType

  Доменные сущности несут в себе бизнес-логику:

  Enclosure — ограничивает количество животных

  Animal — логика изменения состояния (например, лечение)

  Явно выделены предметные сущности: животные, вольеры, расписание кормлений

  Реализована изоляция предметной области в слое Domain



# *Запуск*

  Через cmd в папке проекта написать команду *dotnet run*, перейти по адресу local host'a
