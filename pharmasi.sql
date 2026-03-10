-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 10 fév. 2026 à 21:02
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `pharmasi`
--

-- --------------------------------------------------------

--
-- Structure de la table `appartenir`
--

CREATE TABLE `appartenir` (
  `IdProduit` int(11) NOT NULL,
  `idFamille` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `appartenir`
--

INSERT INTO `appartenir` (`IdProduit`, `idFamille`) VALUES
(1, 1),
(2, 1),
(2, 3),
(3, 2);

-- --------------------------------------------------------

--
-- Structure de la table `composant`
--

CREATE TABLE `composant` (
  `idComposant` int(11) NOT NULL,
  `libelle` varchar(50) DEFAULT NULL,
  `quantite` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `composant`
--

INSERT INTO `composant` (`idComposant`, `libelle`, `quantite`) VALUES
(1, 'Paracétamol', 1000.00),
(2, 'Ibuprofène', 400.00),
(3, 'Amoxicilline', 500.00),
(4, 'Excipient sucre', 10.00);

-- --------------------------------------------------------

--
-- Structure de la table `composer`
--

CREATE TABLE `composer` (
  `IdProduit` int(11) NOT NULL,
  `idComposant` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `composer`
--

INSERT INTO `composer` (`IdProduit`, `idComposant`) VALUES
(1, 1),
(1, 4),
(2, 2),
(3, 3);

-- --------------------------------------------------------

--
-- Structure de la table `diplome`
--

CREATE TABLE `diplome` (
  `id_diplome` int(11) NOT NULL,
  `libelle` varchar(50) NOT NULL,
  `niveau` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `diplome`
--

INSERT INTO `diplome` (`id_diplome`, `libelle`, `niveau`) VALUES
(1, 'Doctorat de Médecine', 'Bac+8'),
(2, 'DU Chirurgie', 'Bac+1'),
(3, 'Diplôme Neurologie', 'Bac+9');

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

CREATE TABLE `employe` (
  `id_employe` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `mail` varchar(100) DEFAULT NULL,
  `mdp` varchar(255) NOT NULL,
  `telephone` varchar(20) DEFAULT NULL,
  `adresse` varchar(255) DEFAULT NULL,
  `code_postal` varchar(10) DEFAULT NULL,
  `sexe` varchar(10) DEFAULT NULL,
  `id_poste` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `employe`
--

INSERT INTO `employe` (`id_employe`, `nom`, `prenom`, `mail`, `mdp`, `telephone`, `adresse`, `code_postal`, `sexe`, `id_poste`) VALUES
(1, 'Durand', 'Toto', 'toto@example.com', '9a45271efef868a31ebbd528c407c678c33d8982871d92da3a766c1283c12f69', '0600000001', '10 rue de la Paix', '75001', 'Homme', 1),
(2, 'Martin', 'Alice', 'alice@pharmasi.test', '4e40e8ffe0ee32fa53e139147ed559229a5930f89c2204706fc174beb36210b3', '0600000002', '25 av. République', '69002', 'Femme', 2),
(3, 'Bernard', 'Luc', 'luc@pharmasi.test', '8b5751f470604a14bd6c27918d91cc2f05a4f961f616e534d71db92996111f3a', '0600000003', '5 bd Gambetta', '13001', 'Homme', 3),
(4, 'Petit', 'Sophie', 'sophie.petit@pharmasi.test', '9cfd406c5d9da19371996f85653f877ad8086079d51750fea625c6c3aea82e8e', '0600000004', '8 imp. des Lilas', '33000', 'Femme', 4);

-- --------------------------------------------------------

--
-- Structure de la table `famille`
--

CREATE TABLE `famille` (
  `idFamille` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `famille`
--

INSERT INTO `famille` (`idFamille`, `nom`) VALUES
(1, 'Antalgique'),
(2, 'Antibiotique'),
(3, 'Anti-inflammatoire');

-- --------------------------------------------------------

--
-- Structure de la table `posseder`
--

CREATE TABLE `posseder` (
  `id_praticien` int(11) NOT NULL,
  `id_diplome` int(11) NOT NULL,
  `id_specialite` int(11) NOT NULL,
  `coefficient_prescription` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `posseder`
--

INSERT INTO `posseder` (`id_praticien`, `id_diplome`, `id_specialite`, `coefficient_prescription`) VALUES
(1, 3, 1, 12.50),
(2, 1, 3, 8.40);

-- --------------------------------------------------------

--
-- Structure de la table `poste`
--

CREATE TABLE `poste` (
  `id_poste` int(11) NOT NULL,
  `libelle` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `poste`
--

INSERT INTO `poste` (`id_poste`, `libelle`) VALUES
(1, 'Visiteur'),
(2, 'Responsable secteur'),
(3, 'Délégué régional'),
(4, 'Secrétaire');

-- --------------------------------------------------------

--
-- Structure de la table `praticien`
--

CREATE TABLE `praticien` (
  `idPraticien` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `adresse` varchar(100) DEFAULT NULL,
  `code_postal` varchar(5) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `coefficient_notoriete` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `praticien`
--

INSERT INTO `praticien` (`idPraticien`, `nom`, `prenom`, `adresse`, `code_postal`, `ville`, `coefficient_notoriete`) VALUES
(1, 'House', 'Gregory', '221B Baker Street', '59000', 'Lille', 98.50),
(2, 'Cymes', 'Michel', '10 rue de la TV', '75000', 'Paris', 85.00),
(3, 'Grey', 'Meredith', 'Seattle Grace Hospital', '99000', 'Seattle', 70.20);

-- --------------------------------------------------------

--
-- Structure de la table `praticien_type`
--

CREATE TABLE `praticien_type` (
  `id_praticien` int(11) NOT NULL,
  `id_type` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `praticien_type`
--

INSERT INTO `praticien_type` (`id_praticien`, `id_type`) VALUES
(1, 2),
(2, 2),
(3, 3);

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

CREATE TABLE `produit` (
  `IdProduit` int(11) NOT NULL,
  `NumeroDuProduit` varchar(50) DEFAULT NULL,
  `PrixEchantillon` decimal(10,2) DEFAULT NULL,
  `EffetsTherapeutiques` varchar(255) DEFAULT NULL,
  `Contre_indications` varchar(255) DEFAULT NULL,
  `Interactions` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`IdProduit`, `NumeroDuProduit`, `PrixEchantillon`, `EffetsTherapeutiques`, `Contre_indications`, `Interactions`) VALUES
(1, 'DOLI-1000', 2.50, 'Douleurs et fièvre', 'Allergie paracétamol', 'Aucune'),
(2, 'ADVIL-400', 3.90, 'Inflammation et douleur', 'Ulcère estomac', 'Anticoagulants'),
(3, 'CLAMOXYL', 5.60, 'Infection bactérienne', 'Allergie Pénicilline', 'Méthotrexate');

-- --------------------------------------------------------

--
-- Structure de la table `specialite`
--

CREATE TABLE `specialite` (
  `id_specialite` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `specialite`
--

INSERT INTO `specialite` (`id_specialite`, `nom`) VALUES
(1, 'Médecine Interne'),
(2, 'Chirurgie Générale'),
(3, 'ORL');

-- --------------------------------------------------------

--
-- Structure de la table `type_praticien`
--

CREATE TABLE `type_praticien` (
  `id_type` int(11) NOT NULL,
  `libelle` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `type_praticien`
--

INSERT INTO `type_praticien` (`id_type`, `libelle`) VALUES
(1, 'Médecin Généraliste'),
(2, 'Médecin Spécialiste'),
(3, 'Hospitalier');

-- --------------------------------------------------------

--
-- Structure de la table `visite`
--

CREATE TABLE `visite` (
  `idVisite` int(11) NOT NULL,
  `id_employe` int(11) NOT NULL,
  `idPraticien` int(11) NOT NULL,
  `dateVisite` date NOT NULL,
  `rapport` longtext NOT NULL,
  `duree_visite` int(11) DEFAULT NULL,
  `date_creation` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `visite`
--

INSERT INTO `visite` (`idVisite`, `id_employe`, `idPraticien`, `dateVisite`, `rapport`, `duree_visite`, `date_creation`) VALUES
(1, 1, 2, '2026-02-09', 'qsdxc', 6, '2026-02-09 22:43:12'),
(2, 3, 3, '2026-02-10', 'test view', NULL, '2026-02-10 12:10:57');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `appartenir`
--
ALTER TABLE `appartenir`
  ADD PRIMARY KEY (`IdProduit`,`idFamille`),
  ADD KEY `idFamille` (`idFamille`);

--
-- Index pour la table `composant`
--
ALTER TABLE `composant`
  ADD PRIMARY KEY (`idComposant`);

--
-- Index pour la table `composer`
--
ALTER TABLE `composer`
  ADD PRIMARY KEY (`IdProduit`,`idComposant`),
  ADD KEY `idComposant` (`idComposant`);

--
-- Index pour la table `diplome`
--
ALTER TABLE `diplome`
  ADD PRIMARY KEY (`id_diplome`);

--
-- Index pour la table `employe`
--
ALTER TABLE `employe`
  ADD PRIMARY KEY (`id_employe`),
  ADD KEY `id_poste` (`id_poste`);

--
-- Index pour la table `famille`
--
ALTER TABLE `famille`
  ADD PRIMARY KEY (`idFamille`);

--
-- Index pour la table `posseder`
--
ALTER TABLE `posseder`
  ADD PRIMARY KEY (`id_praticien`,`id_diplome`,`id_specialite`),
  ADD KEY `id_diplome` (`id_diplome`),
  ADD KEY `id_specialite` (`id_specialite`);

--
-- Index pour la table `poste`
--
ALTER TABLE `poste`
  ADD PRIMARY KEY (`id_poste`);

--
-- Index pour la table `praticien`
--
ALTER TABLE `praticien`
  ADD PRIMARY KEY (`idPraticien`);

--
-- Index pour la table `praticien_type`
--
ALTER TABLE `praticien_type`
  ADD PRIMARY KEY (`id_praticien`,`id_type`),
  ADD KEY `id_type` (`id_type`);

--
-- Index pour la table `produit`
--
ALTER TABLE `produit`
  ADD PRIMARY KEY (`IdProduit`);

--
-- Index pour la table `specialite`
--
ALTER TABLE `specialite`
  ADD PRIMARY KEY (`id_specialite`);

--
-- Index pour la table `type_praticien`
--
ALTER TABLE `type_praticien`
  ADD PRIMARY KEY (`id_type`);

--
-- Index pour la table `visite`
--
ALTER TABLE `visite`
  ADD PRIMARY KEY (`idVisite`),
  ADD KEY `id_employe` (`id_employe`),
  ADD KEY `idPraticien` (`idPraticien`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `composant`
--
ALTER TABLE `composant`
  MODIFY `idComposant` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `diplome`
--
ALTER TABLE `diplome`
  MODIFY `id_diplome` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `employe`
--
ALTER TABLE `employe`
  MODIFY `id_employe` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `famille`
--
ALTER TABLE `famille`
  MODIFY `idFamille` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `poste`
--
ALTER TABLE `poste`
  MODIFY `id_poste` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `praticien`
--
ALTER TABLE `praticien`
  MODIFY `idPraticien` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `produit`
--
ALTER TABLE `produit`
  MODIFY `IdProduit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `specialite`
--
ALTER TABLE `specialite`
  MODIFY `id_specialite` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `type_praticien`
--
ALTER TABLE `type_praticien`
  MODIFY `id_type` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `visite`
--
ALTER TABLE `visite`
  MODIFY `idVisite` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `appartenir`
--
ALTER TABLE `appartenir`
  ADD CONSTRAINT `appartenir_ibfk_1` FOREIGN KEY (`IdProduit`) REFERENCES `produit` (`IdProduit`),
  ADD CONSTRAINT `appartenir_ibfk_2` FOREIGN KEY (`idFamille`) REFERENCES `famille` (`idFamille`);

--
-- Contraintes pour la table `composer`
--
ALTER TABLE `composer`
  ADD CONSTRAINT `composer_ibfk_1` FOREIGN KEY (`IdProduit`) REFERENCES `produit` (`IdProduit`),
  ADD CONSTRAINT `composer_ibfk_2` FOREIGN KEY (`idComposant`) REFERENCES `composant` (`idComposant`);

--
-- Contraintes pour la table `employe`
--
ALTER TABLE `employe`
  ADD CONSTRAINT `employe_ibfk_1` FOREIGN KEY (`id_poste`) REFERENCES `poste` (`id_poste`);

--
-- Contraintes pour la table `posseder`
--
ALTER TABLE `posseder`
  ADD CONSTRAINT `posseder_ibfk_1` FOREIGN KEY (`id_praticien`) REFERENCES `praticien` (`idPraticien`),
  ADD CONSTRAINT `posseder_ibfk_2` FOREIGN KEY (`id_diplome`) REFERENCES `diplome` (`id_diplome`),
  ADD CONSTRAINT `posseder_ibfk_3` FOREIGN KEY (`id_specialite`) REFERENCES `specialite` (`id_specialite`);

--
-- Contraintes pour la table `praticien_type`
--
ALTER TABLE `praticien_type`
  ADD CONSTRAINT `praticien_type_ibfk_1` FOREIGN KEY (`id_praticien`) REFERENCES `praticien` (`idPraticien`),
  ADD CONSTRAINT `praticien_type_ibfk_2` FOREIGN KEY (`id_type`) REFERENCES `type_praticien` (`id_type`);

--
-- Contraintes pour la table `visite`
--
ALTER TABLE `visite`
  ADD CONSTRAINT `visite_ibfk_1` FOREIGN KEY (`id_employe`) REFERENCES `employe` (`id_employe`),
  ADD CONSTRAINT `visite_ibfk_2` FOREIGN KEY (`idPraticien`) REFERENCES `praticien` (`idPraticien`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
