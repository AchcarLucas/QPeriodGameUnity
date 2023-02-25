using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Classe 'Creator' é responsável pela inicialização de estruturas essenciais 
    que serão usados ao longo do jogo.
    OBS: poderia ser feito direto pelo editor da unity, porém, achei melhor 
    ter essa classe estática para fazer isso por mim.
*/

public static class Creator
{
    public static List<Element> CreateChemicalElements()
    {
        Debug.Log("[Creator] - CreateChemicalElements");

        List<Element> elements = new List<Element>();

        // Element(Column, Line, AtomicNumber, ElementName, ElementSymbol, TMaterial)

        // Não metais
        elements.Add(new Element(1, 1, 1, "Hidrogênio", "H", Settings.TypeMaterial.NotMetal));

        // --------------------------------------------------------------------------------------

        // Metais alcalinos
        elements.Add(new Element(1, 2, 3, "Lítio", "Li", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 3, 11, "Sódio", "Na", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 4, 19, "Potássio", "K", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 5, 37, "Rubídio", "Rb", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 6, 55, "Césio", "Cs", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 7, 87, "Frâncio", "Fr", Settings.TypeMaterial.AlkalineMetal));

        // --------------------------------------------------------------------------------------

        // Metais alcalino-terrosos
        elements.Add(new Element(2, 2, 4, "Berílio", "Be", Settings.TypeMaterial.AlkalineEarthMetal));
        elements.Add(new Element(2, 3, 12, "Magnésio", "Mg", Settings.TypeMaterial.AlkalineEarthMetal));
        elements.Add(new Element(2, 4, 20, "Cálcio", "Ca", Settings.TypeMaterial.AlkalineEarthMetal));
        elements.Add(new Element(2, 5, 38, "Estrôncio", "Sr", Settings.TypeMaterial.AlkalineEarthMetal));
        elements.Add(new Element(2, 6, 56, "Bário", "Ba", Settings.TypeMaterial.AlkalineEarthMetal));
        elements.Add(new Element(2, 7, 88, "Rádio", "Ra", Settings.TypeMaterial.AlkalineEarthMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 3)
        elements.Add(new Element(3, 4, 21, "Escândio", "Sc", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(3, 5, 39, "Ítrio", "Y", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 4)
        elements.Add(new Element(4, 4, 22, "Titânio", "Ti", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(4, 5, 40, "Zircônio", "Zr", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(4, 6, 72, "Háfnio", "Hf", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(4, 7, 104, "Rutherfórdio", "Rf", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 5)
        elements.Add(new Element(5, 4, 23, "Vanádio", "V", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(5, 5, 41, "Nióbio", "Nb", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(5, 6, 73, "Tântalo", "Ta", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(5, 7, 105, "Dúbnio", "Db", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 6)
        elements.Add(new Element(6, 4, 24, "Cromo", "Cr", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(6, 5, 42, "Molibdênio", "Mo", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(6, 6, 74, "Tungstênio", "W", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(6, 7, 106, "Seabórgio", "Sg", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 7)
        elements.Add(new Element(7, 4, 25, "Manganês", "Mn", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(7, 5, 43, "Tecnécio", "Tc", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(7, 6, 75, "Rênio", "Re", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(7, 7, 107, "Bóhrio", "Bh", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 8)
        elements.Add(new Element(8, 4, 26, "Ferro", "Fe", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(8, 5, 44, "Rutênio", "Ru", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(8, 6, 76, "Ósmio", "Os", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(8, 7, 108, "Hássio", "Hs", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 9)
        elements.Add(new Element(9, 4, 27, "Cobalto", "Co", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(9, 5, 45, "Ródio", "Rh", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(9, 6, 77, "Irídio", "Ir", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(9, 7, 109, "Meitnério", "Mt", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 10)
        elements.Add(new Element(10, 4, 28, "Níquel", "Ni", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(10, 5, 46, "Paládio", "Pd", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(10, 6, 78, "Platina", "Pt", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(10, 7, 110, "Darmstádio", "Ds", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 11)
        elements.Add(new Element(11, 4, 29, "Cobre", "Cu", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(11, 5, 47, "Prata", "Ag", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(11, 6, 79, "Ouro", "Au", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(11, 7, 111, "Roentgênio", "Rg", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Metais de transição (Grupo 12)
        elements.Add(new Element(12, 4, 30, "Zinco", "Zn", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(12, 5, 48, "Cádmio", "Cd", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(12, 6, 80, "Mercúrio", "Hg", Settings.TypeMaterial.TransitionMetal));
        elements.Add(new Element(12, 7, 112, "Copernício", "Cn", Settings.TypeMaterial.TransitionMetal));

        // --------------------------------------------------------------------------------------

        // Semimetais (Grupo 13)
        elements.Add(new Element(13, 2, 5, "Boro", "B", Settings.TypeMaterial.SemiMetal));

        // Outros Metais (Grupo 13)
        elements.Add(new Element(13, 3, 13, "Alumínio", "Al", Settings.TypeMaterial.OthersMetal));
        elements.Add(new Element(13, 4, 31, "Gálio", "Ga", Settings.TypeMaterial.OthersMetal));
        elements.Add(new Element(13, 5, 49, "Índio", "In", Settings.TypeMaterial.OthersMetal));
        elements.Add(new Element(13, 6, 81, "Tálio", "Tl", Settings.TypeMaterial.OthersMetal));
        elements.Add(new Element(13, 7, 113, "Nihonium", "Nh", Settings.TypeMaterial.OthersMetal));

        // --------------------------------------------------------------------------------------

        // Não Metais (Grupo 14)
        elements.Add(new Element(14, 2, 6, "Carbono", "C", Settings.TypeMaterial.NotMetal));

        // Semimetais (Grupo 14)
        elements.Add(new Element(14, 3, 14, "Silício", "Si", Settings.TypeMaterial.SemiMetal));
        elements.Add(new Element(14, 4, 32, "Germânio", "Ge", Settings.TypeMaterial.SemiMetal));

        // Outros Metais (Grupo 14)
        elements.Add(new Element(14, 5, 50, "Estanho", "Sn", Settings.TypeMaterial.OthersMetal));
        elements.Add(new Element(14, 6, 82, "Chumbo", "Pb", Settings.TypeMaterial.OthersMetal));
        elements.Add(new Element(14, 7, 114, "Fleróvio", "Fl", Settings.TypeMaterial.OthersMetal));

        // --------------------------------------------------------------------------------------

        // Não Metais (Grupo 15)
        elements.Add(new Element(15, 2, 7, "Nitrogênio", "N", Settings.TypeMaterial.NotMetal));
        elements.Add(new Element(15, 3, 15, "Fósforo", "P", Settings.TypeMaterial.NotMetal));

        // Semimetais (Grupo 15)
        elements.Add(new Element(15, 4, 33, "Arsênio", "As", Settings.TypeMaterial.SemiMetal));
        elements.Add(new Element(15, 5, 51, "Antimônio", "Sb", Settings.TypeMaterial.SemiMetal));

        // Outros Metais (Grupo 15)
        elements.Add(new Element(15, 6, 83, "Bismuto", "Bi", Settings.TypeMaterial.OthersMetal));
        elements.Add(new Element(15, 7, 115, "Moscóvio", "Mc", Settings.TypeMaterial.OthersMetal));

        // --------------------------------------------------------------------------------------

        // Não Metais (Grupo 16)
        elements.Add(new Element(16, 2, 8, "Oxigênio", "O", Settings.TypeMaterial.NotMetal));
        elements.Add(new Element(16, 3, 16, "Enxofre", "S", Settings.TypeMaterial.NotMetal));
        elements.Add(new Element(16, 4, 34, "Selênio", "Se", Settings.TypeMaterial.NotMetal));

        // Semimetais (Grupo 16)
        elements.Add(new Element(16, 5, 52, "Telúrio", "Te", Settings.TypeMaterial.SemiMetal));
        elements.Add(new Element(16, 6, 84, "Polônio", "Po", Settings.TypeMaterial.SemiMetal));

        // Outros Metais (Grupo 16)
        elements.Add(new Element(16, 7, 116, "Livermório", "Lv", Settings.TypeMaterial.OthersMetal));

        // --------------------------------------------------------------------------------------

        // Não Metais (Grupo 17)
        elements.Add(new Element(17, 2, 9, "Flúor", "F", Settings.TypeMaterial.Halogens));
        elements.Add(new Element(17, 3, 17, "Cloro", "Cl", Settings.TypeMaterial.Halogens));
        elements.Add(new Element(17, 4, 35, "Bromo", "Br", Settings.TypeMaterial.Halogens));
        elements.Add(new Element(17, 5, 53, "Iodo", "I", Settings.TypeMaterial.Halogens));
        elements.Add(new Element(17, 6, 85, "Ástato", "At", Settings.TypeMaterial.Halogens));
        elements.Add(new Element(17, 7, 117, "Tenessino", "Ts", Settings.TypeMaterial.Halogens));

        // --------------------------------------------------------------------------------------

        // Gases nobres
        elements.Add(new Element(18, 1, 2, "Hélio", "He", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 2, 10, "Neônio", "Ne", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 3, 18, "Argônio", "Ar", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 4, 36, "Cripônio", "Kr", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 5, 54, "Xenônio", "Xe", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 6, 86, "Radônio", "Rn", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 7, 118, "Oganessônio", "Og", Settings.TypeMaterial.NobleGases));

        // --------------------------------------------------------------------------------------

        // Actinídios
        elements.Add(new Element(4, 9, 89, "Actídio", "Ac", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(5, 9, 90, "Tório", "Th", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(6, 9, 91, "Protactídio", "Pa", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(7, 9, 92, "Urânio", "U", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(8, 9, 93, "Netúnio", "Np", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(9, 9, 94, "Plutônio", "Pu", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(10, 9, 95, "Amerício", "Am", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(11, 9, 96, "Cúrio", "Cm", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(12, 9, 97, "Berquélio", "Bk", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(13, 9, 98, "Califórnio", "Cf", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(14, 9, 99, "Einsténio", "Es", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(15, 9, 100, "Férmio", "Fm", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(16, 9, 101, "Mendelévio", "Md", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(17, 9, 102, "Nobélio", "No", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(18, 9, 103, "Laurêncio", "Lr", Settings.TypeMaterial.Actinidia));

        // Lantanídeos
        elements.Add(new Element(4, 8, 57, "Lantânio", "La", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(5, 8, 58, "Cério", "Ce", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(6, 8, 59, "Praseodímio", "Pr", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(7, 8, 60, "Neodímio", "Nd", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(8, 8, 61, "Promécio", "Pm", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(9, 8, 62, "Samário", "Sm", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(10, 8, 63, "Európio", "Eu", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(11, 8, 64, "Gadolínio", "Gd", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(12, 8, 65, "Térbio", "Tb", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(13, 8, 66, "Disprósio", "Dy", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(14, 8, 67, "Hólmio", "Ho", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(15, 8, 68, "Érbio", "Er", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(16, 8, 69, "Túlio", "Tm", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(17, 8, 70, "Itérbio", "Yb", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(18, 8, 71, "Lutécio", "Lu", Settings.TypeMaterial.Lanthanides));

        return elements;
    }
}
